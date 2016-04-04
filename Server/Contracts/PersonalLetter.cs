﻿namespace Contracts
{
    public class PersonalLetter
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int LoginCount { get; set; }
        public bool Active { get; set; }
        public Company Company { get; set; }
    }
}
