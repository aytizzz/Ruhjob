﻿namespace Ruhjobsss.DataAccess.Entity
{
    public class Job
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }

        public DateTime CreateDate { get; set; }
        public string Price { get; set; }

        public int CategoryID { get; set; }

        public Category Category { get; set; }








    }
}
