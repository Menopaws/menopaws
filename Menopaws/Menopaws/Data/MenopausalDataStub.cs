using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Menopaws.Models;
using Menopaws.Data;

namespace Menopaws.Data
{
    class MenopausalDataStub : IMenopausalDataStore
    {
        public String AddEvent(MenopausalEvent menopausalEvent)
        {
            return "Success!";
        }

        public List<MenopausalEvent> GetAllMenopausalEvents()
        {
            return new List<MenopausalEvent>
            {
                new MenopausalEvent
                {
                    ID = 1,
                    Name = "Hot flush 01",
                    Notes = "Hot flush 01",
                    Date = System.DateTime.Now,
                    Time = System.DateTime.Now.TimeOfDay,
                    Description = "Hot flush",
                    IsTrigger = false,
                    Intensity = 3,
                    Done = true
                },
                new MenopausalEvent
                {
                    ID = 2,
                    Name = "Hot flush 02",
                    Notes = "Hot flush 02",
                    Date = System.DateTime.Now.AddDays(-3),
                    Time = System.DateTime.Now.TimeOfDay,
                    Description = "Hot flush",
                    IsTrigger = false,
                    Intensity = 4,
                    Done = true
                },
                new MenopausalEvent
                {
                    ID = 3,
                    Name = "Hot flush 03",
                    Notes = "Hot flush 03",
                    Date = System.DateTime.Now.AddDays(-2),
                    Time = System.DateTime.Now.TimeOfDay,
                    Description = "Hot flush",
                    IsTrigger = false,
                    Intensity = 1,
                    Done = true
                },
                new MenopausalEvent
                {
                    ID = 4,
                    Name = "Not myself! 04",
                    Notes = "Not myself! 04",
                    Date = System.DateTime.Now,
                    Time = System.DateTime.Now.TimeOfDay,
                    Description = "Not myself",
                    IsTrigger = true,
                    Intensity = 1,
                    Done = true
                },
                new MenopausalEvent
                {
                    ID = 5,
                    Name = "Not myself! 05",
                    Notes = "Not myself! 05",
                    Date = System.DateTime.Now.AddDays(-1),
                    Time = System.DateTime.Now.TimeOfDay,
                    Description = "Not myself",
                    IsTrigger = true,
                    Intensity = 1,
                    Done = true
                },
                new MenopausalEvent
                {
                    ID = 6,
                    Name = "Not myself! 06",
                    Notes = "Not myself! 06",
                    Date = System.DateTime.Now.AddDays(-2),
                    Time = System.DateTime.Now.TimeOfDay,
                    Description = "Not myself",
                    IsTrigger = true,
                    Intensity = 1,
                    Done = true
                }
            };
        }
    }
}
