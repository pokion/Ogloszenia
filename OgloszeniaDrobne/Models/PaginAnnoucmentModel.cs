﻿namespace OgloszeniaDrobne.Models
{
    public class PaginAnnoucmentModel
    {
        public int Page { get; set; }
        public int Total { get; set; }
        public int Size { get; set; } = 9;
        public List<Announcement> Data { get; set; } = new List<Announcement>();
        public List<Category> Categories { get; set; } = new List<Category>();
        public string SearchString { get; set; } = String.Empty;
    }
}
