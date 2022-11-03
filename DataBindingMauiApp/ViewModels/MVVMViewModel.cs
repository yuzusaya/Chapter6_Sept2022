using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using DataBindingMauiApp.Models;

namespace DataBindingMauiApp.ViewModels
{
    public class MVVMViewModel : BaseViewModel
    {
        public ICommand ButtonClickedCommand { get; }
        public MVVMViewModel()
        {
            ButtonClickedCommand = new Command<string>(ButtonClicked);
            //ButtonClickedCommand = new Command(() =>
            //{

            //});

            //fetch ur data from api
        }

        public void ButtonClicked(string title)
        {
            Shell.Current.DisplayAlert(title, "Button clicked", "OK");
        }

        public List<Student> Students => new List<Student>
        {
            new Student{Id=1,Name="Test",Gender="Unknown",Status="Active"},
            new Student{Id=1,Name="Test2",Gender="Unknown2",Status="Inactive"},
            new Student { Id = 1, Name = "Test3", Gender = "Unknown2", Status = "Active" },
        };

        //public List<Student> Students
        //{
        //    get
        //    {
        //        return new List<Student>
        //{
        //    new Student{Id=1,Name="Test",Gender="Unknown",Status="Active"},
        //    new Student{Id=1,Name="Test2",Gender="Unknown2",Status="Inactive"},
        //    new Student { Id = 1, Name = "Test3", Gender = "Unknown2", Status = "Active" },
        //};
        //    }
        //}

    }
}
