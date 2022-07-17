using System;
using System.Collections.Generic;
using System.Text;

namespace PtDDD.Infrastructure.Common.Dto
{
    public class DataResult
    {
        public bool IsSuccess { get; set; }

        public string Message { get; set; }

        public object? Data { get; set; } = null;


        public static DataResult Success(string message)
        {
            return new DataResult
            {
                IsSuccess = true,
                Message = message
            };
        }

        public static DataResult False(string message) 
        {
            return new DataResult
            {
                IsSuccess = false,
                Message = message
            };
        }
    }   
}
