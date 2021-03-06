﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using WeatherDb.Model;

namespace WeatherDb.Abstract
{
    public interface IWeatherDbService
    {
        Task AddWeatherForecastAsync(WeatherForecast forecast);

        Task<IEnumerable<WeatherForecast>> GetLatestHourAsync();

        Task<IEnumerable<WeatherForecast>> GetPeriodAsync(DateTime start, DateTime stop);
    }
}