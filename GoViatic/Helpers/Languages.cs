﻿using Goviatic.Interfaces;
using GoViatic.Resources;
using Xamarin.Forms;

namespace GoViatic.Helpers
{
    public static class Languages
    {
        static Languages()
        {
            var ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
            Resource.Culture = ci;
            DependencyService.Get<ILocalize>().SetLocale(ci);
        }

        public static object Choose => Resource.Choose;
        public static string NavTittleCreateTrip => Resource.NavTittleCreateTripPage;
        public static string NavTittleEditTrip => Resource.NavTittleEditTripPage;
        public static string CreateTripTittle => Resource.CreateTripTittle;
        public static string EditTripTittle => Resource.EditTripTittle;
        public static string Error => Resource.Error;
        public static string Accept => Resource.Accept;
        public static string Edited => Resource.Edited;
        public static string Created => Resource.Created;
        public static string CreateEditTripConfirm => Resource.CreateEditTripConfirm;
        public static string Confirm => Resource.Confirm;
        public static string QuestionT => Resource.QuestionT;
        public static string QuestionV => Resource.QuestionV;
        public static string Yes => Resource.Yes;
        public static string No => Resource.No;
        public static string NavTittleCreateViatic => Resource.NavTittleCreateViaticPage;
        public static string NavTittleEditViatic => Resource.NavTittleEditViaticPage;
        public static string CreateViaticTittle => Resource.CreateViaticTittle;
        public static string EditViaticTittle => Resource.EditViaticTittle;

        public static string TripEditCreation => Resource.TripEditCreation;
    }
}