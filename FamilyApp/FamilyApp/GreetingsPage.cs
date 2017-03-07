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

            var scroll = new ScrollView();
            Content = scroll;
            var stack = new StackLayout();
            stack.Children.Add(new BoxView {  HeightRequest = 600, WidthRequest = 600 });
            stack.Children.Add(new Entry());
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
                            + "The first member of my family is me, ",
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        },
                        new Span
                        {
                            Text = "Parker \n",
                            ForegroundColor = Color.Red,
                            FontAttributes = FontAttributes.Bold,
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),

                        },
                        new Span
                        {
                            Text = "In my free time I enjoy traveling around the world." +
                                   "My favorite places to visit are in South East Asia. " + Environment.NewLine + "",
                                   FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        },
                        new Span
                        {
                            Text = "Next you have my mother,",
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        },
                        new Span
                        {
                            Text = "Anne. \n",
                            ForegroundColor = Color.Pink,
                            FontAttributes = FontAttributes.Bold,
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),

                        },
                        new Span
                        {
                            Text = "She works at a dental office. " +
                                   " She also make wicked good food." + Environment.NewLine + "",
                                   FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        },
                        new Span
                        {
                            Text = "And my father,",
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        },
                        new Span
                        {
                            Text = " Brian. \n",
                            ForegroundColor = Color.Blue,
                            FontAttributes = FontAttributes.Bold,
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        },
                        new Span
                        {
                            Text = "My dad works at an Airline." +
                            " He also enjoys traveling. " + Environment.NewLine + "",
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        },
                        new Span
                        {
                            Text = "We also have my brother,",
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        },
                        new Span
                        {
                            Text = " Peyton. \n",
                            ForegroundColor = Color.Purple,
                            FontAttributes = FontAttributes.Bold,
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        },
                        new Span
                        {
                            Text = "He is 18 years old." +
                            " He is attending college at Normandale." + Environment.NewLine + "",
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        },
                        new Span
                        {
                            Text = "Last but not least,",
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        },
                        new Span
                        {
                            Text = "Shadow (My Cat). \n",
                            ForegroundColor = Color.Black,
                            FontAttributes = FontAttributes.Bold,
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        },
                         new Span
                        {
                            Text = " Black cat with white paws." +
                            " He is always getting into trouble.",
                            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
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

