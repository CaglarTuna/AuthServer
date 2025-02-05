﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace SharedLibrary.Dto
{
    public class Response<T> where T:class
    {
        public T Data { get; private set; }

        public int StatusCode { get; private set; }

        [JsonIgnore]
        public bool IsSuccessfull { get; set; }

        public ErrorDto Error { get; set; }

        public static Response<T> Success(T data, int statusCode)
        {
            return new Response<T>{Data = data,StatusCode = statusCode,IsSuccessfull = true};
        }

        public static Response<T> Success(int statusCode)
        {
            return new Response<T> {Data = default,StatusCode = statusCode,IsSuccessfull = true};
        }

        public static Response<T> Fail(ErrorDto errorDto,int statusCode)
        {
            return new Response<T> {Error = errorDto,StatusCode = statusCode,IsSuccessfull = false};
        }

        public static Response<T> Fail(string errorMessage, int statusCode,bool isShown)
        {
            var errorDto = new ErrorDto(errorMessage, isShown);

            return new Response<T> {Error = errorDto,StatusCode = statusCode,IsSuccessfull = false};
        }
    }
}
