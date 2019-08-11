using System;
using System.Collections.Generic;
using System.Text;
using MovieApp.Entities.Enums;

namespace MovieApp.Models
{
    public class SearchModel
    {
        public bool RegularSearch { get; set; }
        public string Value { get; set; }
        public KeywordSearchModel KeywordSearchObject { get; set; }
    }

    public class KeywordSearchModel
    {
        public SearchTypeEnum SearchType { get; set; }
        public KeywordTypeEnum KeyWordType { get; set; }
    }

}
