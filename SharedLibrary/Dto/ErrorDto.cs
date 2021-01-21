using System;
using System.Collections.Generic;
using System.Text;

namespace SharedLibrary.Dto
{
    public class ErrorDto
    {
        public List<string> Errors { get; private set; } = new List<string>();
        public bool IsShown { get; private set; }

        public ErrorDto(string error, bool isShown)
        {
            Errors.Add(error);
            IsShown = true;
        }

        public ErrorDto(List<string> errors, bool isShown)
        {
            Errors = errors;
            IsShown = isShown;
        }
    }
}
