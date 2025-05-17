using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;

namespace PokeApi.Controls
{
    public partial class TypeBadgeControl : ContentView
    {
        public TypeBadgeControl()
        {
            InitializeComponent();
            UpdateColors();
        }

        public static readonly BindableProperty TypeNameProperty =
            BindableProperty.Create(nameof(TypeName), typeof(string), typeof(TypeBadgeControl), propertyChanged: OnTypeNameChanged);

        public string TypeName
        {
            get => (string)GetValue(TypeNameProperty);
            set => SetValue(TypeNameProperty, value);
        }

        public static readonly BindableProperty TextColorProperty =
            BindableProperty.Create(nameof(TextColor), typeof(Color), typeof(TypeBadgeControl), Colors.White);

        public Color TextColor
        {
            get => (Color)GetValue(TextColorProperty);
            set => SetValue(TextColorProperty, value);
        }

        public static readonly BindableProperty BackgroundColorProperty =
            BindableProperty.Create(nameof(BackgroundColor), typeof(Color), typeof(TypeBadgeControl), Colors.Gray);

        public new Color BackgroundColor // Usamos `new` para sobreescribir BackgroundColor de ContentView
        {
            get => (Color)GetValue(BackgroundColorProperty);
            set => SetValue(BackgroundColorProperty, value);
        }

        private static void OnTypeNameChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (TypeBadgeControl)bindable;
            control.UpdateColors();
        }

        private void UpdateColors()
        {
            switch (TypeName?.ToLower())
            {
                case "fire":
                    BackgroundColor = Colors.OrangeRed;
                    TextColor = Colors.White;
                    break;
                case "water":
                    BackgroundColor = Colors.DodgerBlue;
                    TextColor = Colors.White;
                    break;
                case "grass":
                    BackgroundColor = Colors.ForestGreen;
                    TextColor = Colors.White;
                    break;
				case "electric":
                    BackgroundColor = Colors.Gold;
                    TextColor = Colors.Black;
                    break;
				case "Psychic":
                    BackgroundColor = Colors.HotPink;
                    TextColor = Colors.White;
					break;
				case "Ice":
                    BackgroundColor = Colors.LightBlue;
                    TextColor = Colors.White;
					break;
				case "Fighting":
                    BackgroundColor = Colors.Brown;
                    TextColor = Colors.White;
					break;
				case "Poison":
                    BackgroundColor = Colors.Purple;
                    TextColor = Colors.White;
					break;
				case "Ground":
                    BackgroundColor = Colors.SandyBrown;
                    TextColor = Colors.White;
					break;
				case "Flying":
                    BackgroundColor = Colors.SkyBlue;
                    TextColor = Colors.White;
					break;
				case "Bug":
                    BackgroundColor = Colors.OliveDrab;
                    TextColor = Colors.White;
					break;
				case "Rock":
                    BackgroundColor = Colors.Gray;
                    TextColor = Colors.Black;
                    break;
				case "Ghost":
                    BackgroundColor = Colors.MediumPurple;
                    TextColor = Colors.Black;
                    break;
				case "Dragon":
                    BackgroundColor = Colors.MediumSlateBlue;
                    TextColor = Colors.Black;
                    break;
				case "Dark":
                    BackgroundColor = Colors.Black;
                    TextColor = Colors.Black;
                    break;
				case "Steel":
                    BackgroundColor = Colors.Silver;
                    TextColor = Colors.Black;
                    break;
				case "Fairy":
                    BackgroundColor = Colors.LightPink ;
                    TextColor = Colors.Black;
                    break;
				case "Normal":
                    BackgroundColor = Colors.LightGray;
                    TextColor = Colors.Black;
                    break;
            }
        }
    }
}
