using EventApplication.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EventApplication.Models
{
    public class SampleData : DropCreateDatabaseIfModelChanges<EventApplicationContext>
    {
        protected override void Seed(EventApplicationContext  context)
        {
            {

            }
        }
    }
}