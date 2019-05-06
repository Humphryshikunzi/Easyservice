using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected async void Page_Load(object sender, EventArgs e)
        {
        
        HttpClient httpClient = new HttpClient();
            var jsondata = await httpClient.GetStringAsync("https://shiksstudentsapi.azurewebsites.net/api/Students");
            var listdata = JsonConvert.DeserializeObject<List<Students>>(jsondata);

            Dictionary<Students, int> student = new Dictionary<Students, int>();
            for (int i = 0; i < listdata.Count; i++)
            {
                if ((listdata[i].Name != null) && (listdata[i].NationalIdentification != 0)
                                               && (listdata[i].RegistrationNumber != null) &&
                                               (listdata[i].Remainingfeebalance != null))
                {
                    student.Add(new Students()
                    {
                        Name = listdata[i].Name,
                        RegistrationNumber = listdata[i].RegistrationNumber,
                        Remainingfeebalance = listdata[i].Remainingfeebalance,
                        NationalIdentification = listdata[i].NationalIdentification
                    }, listdata[i].Id);
                }
            }

            List<Students> names = new List<Students>();
            List<Students> nationalids = new List<Students>();
            List<Students> regnums = new List<Students>();
            List<Students> remfeebals = new List<Students>();
            foreach (KeyValuePair<Students, int> std in student.OrderBy(i => i.Key.Name))
            {
                names.Add(new Students() { Name = std.Key.Name });
                names.Add(new Students() { Name = null });

            }
            foreach (KeyValuePair<Students, int> std in student.OrderBy(i => i.Key.Name))
            {
                nationalids.Add(new Students() { NationalIdentification = std.Key.NationalIdentification });
                nationalids.Add(new Students() { NationalIdentification = null });

            }
            foreach (KeyValuePair<Students, int> std in student.OrderBy(i => i.Key.Name))
            {
                remfeebals.Add(new Students() { Remainingfeebalance = std.Key.Remainingfeebalance });
                remfeebals.Add(new Students() { Remainingfeebalance = null });

            }
            foreach (KeyValuePair<Students, int> std in student.OrderBy(i => i.Key.Name))
            {
                regnums.Add(new Students() { RegistrationNumber = std.Key.RegistrationNumber });
                regnums.Add(new Students() { RegistrationNumber = null });

            }

            NamesListBox.DataSource = names;
            NamesListBox.DataBind();
            RegNumbersListBox.DataSource = regnums;
            RegNumbersListBox.DataBind();
            RemainFeeBalListBox.DataSource = remfeebals;
            RemainFeeBalListBox.DataBind();
            NationalIdListBox.DataSource = nationalids;
            NationalIdListBox.DataBind();
        }


    }
}