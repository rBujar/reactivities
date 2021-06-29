using System;

namespace Domain
{
    public class Publisher
    {
        public Guid Id {get; set; }
        
        public string Title { get; set;}
        public string Address { get; set;} 
        public string City { get; set;}
        public string Tel { get; set;}
        public string Email { get; set;}
        
        
    }
}