namespace basics.Models;

    
    public class Repository
    
        {
        private static readonly List<Course> _courses=new();
    
         static Repository()
         {
            _courses=new List<Course>()
            {
                 new Course() {Id=1,Title="aspnet kursu",Description="güzel bir kurs",Image="4.jpg",Tags=new string[] {"aspnet","web geliştirme"},isActive=true,isHome=true},
                 new Course() {Id=2,Title="php kursu",Description="güzel bir kurs",Image="10.jpg",Tags=new string[] {"php kursu","web geliştirme"},isActive=true,isHome=true},
                 new Course() {Id=3,Title="django kursu",Description="güzel bir kurs",Image="6.jpg",Tags=new string[] {"django kursu","web geliştirme"},isActive=true,isHome=true},
       
            };
         } 

        public static List<Course> Courses
        {
            get
            {
                return _courses;
            }
        }
        public static Course? GetById(int? id)
        {
           return _courses.FirstOrDefault(c=>c.Id==id);

        }
    }
    