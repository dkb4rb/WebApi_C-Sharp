using API.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace API.Results
{
    public class DefaultResult<T> where T : class
    {
        public int CurrentPage { get; set; }
        public int RecordsPerPage { get; set; }
        public int TotalRecords { get; set; }
        public int TotalPages { get; set; }
        public string CurrentSearch { get; set; }
        public string CurrentSort { get; set; }
        public string CurrentSortType { get; set; }
        public SqlDataReader Resultt { get; set; }
        public IEnumerable<T> Result { get; set; }

    }
}
