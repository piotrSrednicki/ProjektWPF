﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjektWPF.Pages
{
    /// <summary>
    /// Interaction logic for FilmDetails.xaml
    /// </summary>
    public partial class FilmDetails : Page
    {
        Model1 db = new Model1();
        private List<Film> filmsL;
        private ObservableCollection<FilmViewing> filmsViewingsL = new ObservableCollection<FilmViewing>();

        Film film;
        public int LoggedUserId { get; set; }
        string mode;
        public FilmDetails()
        {
            InitializeComponent();
            DataContext = this;         //set data context and create list
            mode = "creation";
            film = new Film();
            deleteFilmButton.Visibility = Visibility.Collapsed; //delete button not needed if the film is being added
        }
        public FilmDetails(int id, string title, DateTime date, bool viewed, string descr)
        {
            InitializeComponent();
            filmsViewingsL = new ObservableCollection<FilmViewing>(db.FilmViewing.Where(item => item.FilmId == id));
            showingsListBox.ItemsSource = filmsViewingsL;
            mode = "edition";
            deleteFilmButton.Visibility = Visibility.Visible;
            filmTitle.Text = title;     //set film data to UI
            filmDate.SelectedDate = date;
            filmViewed.IsChecked = viewed;
            filmDescription.Text = descr;
            filmsL = db.Film.ToList();
            film = filmsL.Find(el => el.Id == id);
            DataContext = this;
        }

        private void saveAddFilm(object sender, RoutedEventArgs e)
        {
            bool validData = true;
            string message = "";
            DateTime parsedDate;
            film.Description = filmDescription.Text; //it can be null
            film.Viewed = (bool)filmViewed.IsChecked;

            if (DateTime.TryParse(filmDate.SelectedDate.ToString(), out parsedDate))
                film.DateOfPremiere = parsedDate; //parse data and check if its valid;
            else
            {
                message = "Date format is invalid";
                validData = false;
            }

            if (filmTitle.Text.Length > 1)
                film.Name = filmTitle.Text; //get values of changed data
            else
            {
                message = "Title is too short";
                validData = false;
            }

            if (mode == "edition" && validData)
            {
                try
                {
                    db.SaveChanges();
                    switchToFilmsList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else if (validData)
            {
                film.UserId = LoggedUserId;
                FilmViewing filmView;
                db.Film.Add(film);
                db.SaveChanges();  //do this again below since id is auto incremented
                /*foreach (string showing in showingsList)
                {
                    filmView = new FilmViewing()
                    {
                        FilmId = film.Id,
                        UserId = LoggedUserId,
                        DateOfViewing = DateTime.Parse(showing),
                    };
                    db.FilmViewing.Add(filmView);
                }*/
                //db.SaveChanges();
                switchToFilmsList();

            }
            else
            {
                validationBorder.Visibility = Visibility.Visible;
                validationBox.Text = message;
            }
        }

        private void deleteFilm(object sender, RoutedEventArgs e)
        {
            try
            {
                db.Film.Remove(film);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            switchToFilmsList();
        }

        private void switchToFilmsList()
        {
            Films filmsList = new Films(LoggedUserId);  //we have to create a new page to refresh the list
            NavigationService navigationService = NavigationService.GetNavigationService(this);
            navigationService.Navigate(filmsList);
        }

        private void addShowing(object sender, RoutedEventArgs e)
        {
            FilmViewing newFilmViewing;
            if (filmsViewingsL.Count < 5)
            {
                newFilmViewing = new FilmViewing()
                {
                    FilmId = film.Id,
                    DateOfViewing = DateTime.Parse(showingDateAndTime.Text),
                };

                filmsViewingsL.Add(newFilmViewing);
                db.FilmViewing.Add(newFilmViewing);

            }
        }

        private void deleteShowing(object sender, MouseButtonEventArgs e)
        {
            db.FilmViewing.Remove((FilmViewing)showingsListBox.SelectedItem); //delete selected item from db                
            filmsViewingsL.Remove((FilmViewing)showingsListBox.SelectedItem);
        }
    }
}