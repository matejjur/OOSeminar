using System.Collections.Generic;
using Seminar.Model;

namespace Seminar.BaseLib
{
    public interface IMainFormController
    {
        // LOGIN
        void UsernameInput(string input);

        void PasswordInput(string input);

        bool LoginUser(IMainFormController _controller);

        void GoToRegistration(IMainFormController _controller);


        // REGISTRATION
        void UsernameInputRegistration(string input);

        void PasswordInputRegistration(string input);

        string RegisterUser(IMainFormController _controller);

        void GoToLogin(IMainFormController _controller);


        // HOME
        void AddNewRecord(IMainFormController _controller);

        List<Record> RefreshData();

        void OpenRecordDetails(IMainFormController _controller, string id);

        void OpenRecordEdit(IMainFormController _controller, string id);

        void Logout(IMainFormController _controller);

        void DeleteAccount(IMainFormController _controller);

        void SortByFeeling(bool sort);

        void SortByDate(bool sort);

        void FilterRecords(IMainFormController _controller);

        void FeelingFilterChange(string input);

        void KeywordsFilterChange(string input);


        // ADD NEW RECORD
        void DescriptionTextChange(string input);

        void DietTextChange(string input);

        void KeywordsTextChange(string input);

        void FeelingChange(string input);

        void DateChange(string input);

        string SaveRecord();


        // EDIT RECORD DETAILS
        void DescriptionEditText(string input);

        void FeelingEditText(string input);

        void DietEditText(string input);

        void KeywordsEditText(string input);

        void SaveEditChanges(string date);

    }
}
