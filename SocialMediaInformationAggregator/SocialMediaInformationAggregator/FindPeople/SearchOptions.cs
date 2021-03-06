﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaInformationAggregator.FindPeople
{
    /// <summary>
    /// Класс, представляющий информация для поиска по социальным сетям.
    /// </summary>
    public class SearchOptions
    {
        private Nullable<int> _yearOfBirth;

        /// <summary>
        /// Инициализирует новый экземпляр класса SearchOptions.
        /// Все параметры по умолчанию равны null.
        /// </summary>
        public SearchOptions()
        {
            this.Name = null;
            this.LastName = null;
            this.YearOfBirth = null;
            this.City = null;
            this.Education = null;
        }

        /// <summary>
        /// Имя искомого человека.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Фамилия искомого человека.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Год рождения искомого человека.
        /// </summary>
        public Nullable<int> YearOfBirth
        {
            get => _yearOfBirth;
            set
            {
                if (value != null && (value < 1900 || value > DateTime.Now.Year))
                    throw new Exception("Год рождения должен лежать в диапозоне от 1990 до текущего года.");

                _yearOfBirth = value;
            }
        }

        /// <summary>
        /// Город проживания искомого человека.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Место учебы искомого человека.
        /// </summary>
        public string Education { get; set; }
    }
}
