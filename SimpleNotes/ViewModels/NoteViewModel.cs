using SimpleNotes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SimpleNotes.ViewModels
{
    public class NoteViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Note Note { get; private set; }

        public NoteViewModel()
        {
            Note = new Note();
        }

        NotesListViewModel nlvm;

        public NotesListViewModel ListViewModel
        {
            get { return nlvm; }
            set
            {
                if (nlvm != value)
                {
                    nlvm = value;
                    OnPropertyChanged("ListViewModel");
                }
            }
        }

        public string Title
        {
            get { return Note.Title; }
            set
            {
                if (Note.Title != value)
                {
                    Note.Title = value;
                    OnPropertyChanged("Title");
                }
            }
        }

        public string Text
        {
            get { return Note.Text; }
            set
            {
                if (Note.Text != value)
                {
                    Note.Text = value;
                    OnPropertyChanged("Text");
                }
            }
        }

        public string CreationData
        {
            get { return Note.CreationData; }
            set
            {
                if (Note.CreationData != value)
                {
                    Note.CreationData = value;
                    OnPropertyChanged("CreationData");
                }
            }
        }

        public string Color
        {
            get { return Note.Color; }
            set
            {
                if (Note.Color != value)
                {
                    Note.Color = value;
                    OnPropertyChanged("Color");
                }
            }
        }

        public int Id
        {
            get { return Note.Id; }
            set
            {
                if (Note.Id != value)
                {
                    Note.Id = value;
                    OnPropertyChanged("Id");
                }
            }
        }

        public bool IsValid
        {
            get
            {
                return ((!string.IsNullOrEmpty(Title.Trim())) ||
                    (!string.IsNullOrEmpty(Text.Trim())) ||
                    (!string.IsNullOrEmpty(Color.Trim())) ||
                    (!string.IsNullOrEmpty(CreationData.Trim())));
            }
        }

        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
