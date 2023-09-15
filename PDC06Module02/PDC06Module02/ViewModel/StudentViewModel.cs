using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;
using PDC06Module02.Model;
using Xamarin.Forms;

namespace PDC06Module02.ViewModel
{
    class StudentViewModel : INotifyPropertyChanged
    {
        public student StudentSet { get; set; }
        public Command SubmitEntry { get; set; }


        public string SubjectCodeEntry { get; set; }
        public string SubjectCodeDisplay { get; set; }

        public string SubjectTitleEntry { get; set; }
        public string SubjectTitleDisplay { get; set; }

        public string SubjectUnitEntry{ get; set; }
        public string SubjectUnitDisplay { get; set; }

        public StudentViewModel() 
        {
            SubmitEntry = new Command(() =>
            {
                StudentSet = new student 
                {
                    Subjectcode = SubjectCodeEntry,
                };

                SubjectCodeDisplay = SubjectCodeEntry;
                SubjectTitleEntry = SubjectTitleEntry;
                SubjectUnitDisplay = SubjectUnitEntry;

                OnPropertyChanged(nameof(SubjectCodeDisplay));
                OnPropertyChanged(nameof(SubjectCodeEntry));

                OnPropertyChanged(nameof(SubjectTitleDisplay));
                OnPropertyChanged(nameof(SubjectTitleEntry));

                OnPropertyChanged(nameof(SubjectUnitDisplay));
                OnPropertyChanged(nameof(SubjectUnitEntry));
            });

        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
