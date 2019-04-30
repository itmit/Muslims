using System;
using System.Collections.Generic;
using System.Text;

namespace Muslims.Models
{
    class NamazTimeRows
    {
        /// <summary>
        /// Возвращает или устанавливает время первого намаза.
        /// </summary>
        public string FirstNamaz { get; set; }

        /// <summary>
        /// Возвращает или устанавливает время второго намаза.
        /// </summary>
        public string SecondNamaz { get; set; }

        /// <summary>
        /// Возвращает или устанавливает время третьего намаза.
        /// </summary>
        public string ThirdNamaz { get; set; }

        /// <summary>
        /// Возвращает или устанавливает время четвертого намаза.
        /// </summary>
        public string FourthNamaz { get; set; }

        /// <summary>
        /// Возвращает или устанавливает время пятого намаза.
        /// </summary>
        public string FifthNamaz { get; set; }

        /// <summary>
        /// Возвращает или устанавливает время шестого намаза.
        /// </summary>
        public string SixthNamaz { get; set; }

        /// <summary>
        /// Возвращает или устанавливает  день проведения намазов.
        /// </summary>
        public string Day { get; set; }

        /// <summary>
        /// Возвращает или устанавливает месяц в котром проводятся намазы.
        /// </summary>
        public string Mouth { get; set; }
    }
}
