using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MicroServicesAssessment.Shared.Dtos
{
    public class Response<T>
    {
        public T Data { get; private set; }

        [JsonIgnore]
        public int StatusCode { get; private set; }

        [JsonIgnore]
        public bool IsSeccussful { get; private set; }

        public List<string> Errors { get; set; }

        //Static Factory Method
        public static Response<T> Success(T data, int statusCode)
        {
            return new Response<T> { Data = data, IsSeccussful = true, StatusCode = statusCode };
        }

        public static Response<T> Success(int statusCode) //Update veya Delete için
        {
            return new Response<T> { Data = default(T), IsSeccussful = true, StatusCode = statusCode };
        }
        public static Response<T> Fail(List<string> errors, int statusCode)
        {
            return new Response<T> { Errors = errors, IsSeccussful = false, StatusCode = statusCode };
        }
        public static Response<T> Fail(string error, int statusCode)
        {
            return new Response<T> { Errors = new List<string>() { error }, IsSeccussful = false, StatusCode = statusCode };
        }
    }
}
