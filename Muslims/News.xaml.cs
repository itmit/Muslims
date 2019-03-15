using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Muslims
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class News : TabbedPage
    {
        public News()
        {
            InitializeComponent();
            Init2();
        }
        public void Init2()
        {
            List<News_Developments_Class> Developments = new List<News_Developments_Class>
            {
                new News_Developments_Class { NewsID_Developments ="1", NewsTitle_Developments = "Событие - 1", NewsContent_Developments ="С другой стороны постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения новых предложений. Товарищи! новая модель организационной деятельности позволяет оценить значение новых предложений. Идейные соображения высшего порядка, а также...", NewsImage_Developments = "spb_1_1.jpg"},
                new News_Developments_Class { NewsID_Developments= "2", NewsTitle_Developments = "Событие - 2", NewsContent_Developments ="Консультация с широким активом создает необходимость включения в производственный план целого ряда внеочередных мероприятий с учетом комплекса новых предложений. Есть над чем задуматься: активно развивающиеся страны третьего мира, вне зависимости от их уровня, должны быть ассоциативно распределены по отраслям. Прежде всего, экономическая повестка сегодняшнего дня способствует подготовке и реализации инновационных методов управления процессами.", NewsImage_Developments = "spb_1_2.jpg"}
            };

            List<News_Activity_Class> Activity = new List<News_Activity_Class>
            {
                new News_Activity_Class { NewsTitle_Activity = "Событие - 1", NewsContent_Activity ="С другой стороны постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения новых предложений. Товарищи! новая модель организационной деятельности позволяет оценить значение новых предложений. Идейные соображения высшего порядка, а также...", NewsImage_Activity = "spb_1_3.jpg"},
                new News_Activity_Class { NewsTitle_Activity = "Событие - 2", NewsContent_Activity ="Консультация с широким активом создает необходимость включения в производственный план целого ряда внеочередных мероприятий с учетом комплекса новых предложений. Есть над чем задуматься: активно развивающиеся страны третьего мира, вне зависимости от их уровня, должны быть ассоциативно распределены по отраслям. Прежде всего, экономическая повестка сегодняшнего дня способствует подготовке и реализации инновационных методов управления процессами.", NewsImage_Activity = "spb_1_4.jpg"}
            };
            List<News_Dates_Class> Dates = new List<News_Dates_Class>
            {
                new News_Dates_Class { NewsTitle_Dates = "Событие - 1", NewsContent_Dates ="С другой стороны постоянное информационно-пропагандистское обеспечение нашей деятельности требуют определения и уточнения новых предложений. Товарищи! новая модель организационной деятельности позволяет оценить значение новых предложений. Идейные соображения высшего порядка, а также...", NewsImage_Dates = "spb_1_5.jpg"},
                new News_Dates_Class { NewsTitle_Dates = "Событие - 2", NewsContent_Dates ="Консультация с широким активом создает необходимость включения в производственный план целого ряда внеочередных мероприятий с учетом комплекса новых предложений. Есть над чем задуматься: активно развивающиеся страны третьего мира, вне зависимости от их уровня, должны быть ассоциативно распределены по отраслям. Прежде всего, экономическая повестка сегодняшнего дня способствует подготовке и реализации инновационных методов управления процессами.", NewsImage_Dates = "spb_1_6.jpg"}
            };

            News_Developments.ItemsSource = Developments;
            News_Activity.ItemsSource = Activity;
            News_Dates.ItemsSource = Dates;

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    {
                        News_Developments.Margin = new Thickness(0, 21, 0, 0);
                        News_Activity.Margin = new Thickness(0, 21, 0, 0);
                        News_Dates.Margin = new Thickness(0, 21, 0, 0);
                        break;
                    }
                case Device.Android:
                    {
                        News_Developments.Margin = new Thickness(0, 21, 0, 0);
                        News_Activity.Margin = new Thickness(0, 21, 0, 0);
                        News_Dates.Margin = new Thickness(0, 21, 0, 0);
                        break;
                    };
            }
        }
        public void ListMenu_NewsSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var Developments = e.SelectedItem as News_Developments_Class;
            if (Developments != null)
            {
                if (Developments.NewsID_Developments.Equals("1"))
                {
                    Navigation.PushAsync(new Test_News_Page());
                }
                ((ListView)sender).SelectedItem = null;
            }
        }
        public class News_Developments_Class
        {
            public string NewsID_Developments
            {
                get;
                set;
            }
            public string NewsTitle_Developments
            {
                get;
                set;
            }
            public string NewsContent_Developments
            {
                get;
                set;
            }
            public string NewsImage_Developments
            {
                get;
                set;
            }
        }
        public class News_Activity_Class
        {
            public string NewsID_Activity
            {
                get;
                set;
            }
            public string NewsTitle_Activity
            {
                get;
                set;
            }
            public string NewsContent_Activity
            {
                get;
                set;
            }
            public string NewsImage_Activity
            {
                get;
                set;
            }
        }
    }
    public class News_Dates_Class
    {
        public string NewsID_Dates
        {
            get;
            set;
        }
        public string NewsTitle_Dates
        {
            get;
            set;
        }
        public string NewsContent_Dates
        {
            get;
            set;
        }
        public string NewsImage_Dates
        {
            get;
            set;
        }
    }
}