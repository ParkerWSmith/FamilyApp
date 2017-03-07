using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FamilyApp
{
    public class GreetingsPage : ContentPage
    {
        public GreetingsPage()
        {
            BackgroundColor = Color.Green;
            Content = new Label
            {

                FormattedText = new FormattedString
                {

                    Spans =
                    {
                        new Span
                        {
                            Text = "Family Introduction" + Environment.NewLine
                            + "The first member of my family is me, "
                        },
                        new Span
                        {
                            Text = "Parker \n",
                            FontAttributes = FontAttributes.Bold,
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),

                        },
                        new Span
                        {
                            Text = "In my free time I enjoy traveling around the world." +
                                   "My favorite places to visit are in South East Asia. " + Environment.NewLine + ""
                        },
                        new Span
                        {
                            Text = "Next you have my mother,",
                        },
                        new Span
                        {
                            Text = "Anne. \n",
                            FontAttributes = FontAttributes.Bold,
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),

                        },
                        new Span
                        {
                            Text = "She works at a dental office. " +
                                   " She also make wicked good food." + Environment.NewLine + ""
                        },
                        new Span
                        {
                            Text = "And my father,"
                        },
                        new Span
                        {
                            Text = " Brian. \n",
                            FontAttributes = FontAttributes.Bold,
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        },
                        new Span
                        {
                            Text = "My dad works at an Airline." +
                            " He also enjoys traveling. " + Environment.NewLine + ""
                        },
                        new Span
                        {
                            Text = "We also have my brother,"
                        },
                        new Span
                        {
                            Text = " Peyton. \n",
                            FontAttributes = FontAttributes.Bold,
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        },
                        new Span
                        {
                            Text = "He is 18 years old." +
                            " He is attending college at Normandale." + Environment.NewLine + ""
                        },
                        new Span
                        {
                            Text = "Last but not least,"
                        },
                        new Span
                        {
                            Text = "Shadow (My Cat). \n",
                            FontAttributes = FontAttributes.Bold,
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        },
                         new Span
                        {
                            Text = " Black cat with white paws." +
                            " He is always getting into trouble."
                        },
                    },
                },

                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
                TextColor = Color.White,
                
            };
        }
    }
}

