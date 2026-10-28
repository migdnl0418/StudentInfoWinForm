using Newtonsoft.Json;
using Student_Info.Model;
using Student_Info.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class StudentAPIService : IStudentDataServices
{
    private readonly HttpClient _httpClient;

    public StudentAPIService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<int> AddStudentAsync(StudentModel student)
    {
        var response = await SendRequestAsync<StudentModel>(HttpMethod.Post, "", student);
        return response.Data?.Id ?? 0;
    }

    public async Task DeleteStudentAsync(int id)
    {
        await SendRequestAsync<StudentModel>(HttpMethod.Delete, "", new { id = id });
    }

    public async Task<List<AcadLevelModel>> GetAcadLevelsAsync()
    {
        var response = await SendRequestAsync<List<AcadLevelModel>>(HttpMethod.Get, "?get-all-acadlevel");
        return response.Data ?? new List<AcadLevelModel>();
    }

    public async Task<List<StudentModel>> GetAllStudentsAsync()
    {
        var response = await SendRequestAsync<List<StudentModel>>(HttpMethod.Get, "?get-all-students");
        return response.Data ?? new List<StudentModel>();
    }

    public async Task<List<SectionModel>> GetSectionsAsync()
    {
        var response = await SendRequestAsync<List<SectionModel>>(HttpMethod.Get, "?get-all-sections");
        return response.Data ?? new List<SectionModel>();
    }

    public async Task<StudentModel> GetStudentByIdAsync(int id)
    {
        try
        {
            var response = await SendRequestAsync<StudentModel>(HttpMethod.Get, $"?id={id}");
            return response.Data;
        }
        catch (Exception)
        {
            throw new Exception($"Failed to retrieve student with ID {id}.");
        }
    }

    public async Task<List<StudentModel>> SearchStudentsAsync(string search)
    {
        string keyword = Uri.EscapeDataString(search);
        var response = await SendRequestAsync<List<StudentModel>>(HttpMethod.Get, $"?search={keyword}");
        return response.Data ?? new List<StudentModel>();
    }

    public async Task UpdateStudentAsync(StudentModel student)
    {
        await SendRequestAsync<StudentModel>(HttpMethod.Put, "", student);
    }

    private async Task<ApiResponse<T>> SendRequestAsync<T>
        (HttpMethod method, string endpoint, object body = null)
    {
        using (var request = new HttpRequestMessage(method, endpoint))
        {
            if (body != null)
            {
                var json = JsonConvert.SerializeObject(body);
                request.Content = new StringContent(json, Encoding.UTF8, "application/json");
            }

            using (var response = await _httpClient.SendAsync(request))
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                ApiResponse<T> result;

                try
                {
                    result = JsonConvert.DeserializeObject<ApiResponse<T>>(responseContent);
                }
                catch (Exception)
                {
                    throw new Exception("Failed to deserialize the response.");
                }

                if (!response.IsSuccessStatusCode || result == null || !result.Success)
                {
                    throw new Exception(result?.Error ?? "An error occurred while processing the request.");
                }
                return result;
            }
        }

    }
}