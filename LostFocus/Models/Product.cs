using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LostFocus.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }

        public const decimal LimitPrice = 500;
        public bool OverLimitPrice => Price > LimitPrice;
    }
    public abstract class BaseEntity : Base
    {
        public int Id { get; set; }
    }

    public abstract class Base : INotifyPropertyChanged, INotifyDataErrorInfo
    {
        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler? PropertyChanged;


        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #region INotifyDataErrorInfo

        public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;

        private readonly IDictionary<string, List<string>> errorsByPropertyName = new Dictionary<string, List<string>>();

        public bool HasErrors => errorsByPropertyName.Any();

        public IEnumerable GetErrors(string? propertyName)
        {
            return errorsByPropertyName.ContainsKey(propertyName) ? errorsByPropertyName[propertyName] : Enumerable.Empty<string>();
        }

        protected void AddError(string propertyName, string error)
        {
            if (!errorsByPropertyName.ContainsKey(propertyName))
                errorsByPropertyName[propertyName] = new List<string>();

            if (!errorsByPropertyName[propertyName].Contains(error))
            {
                errorsByPropertyName[propertyName].Add(error);

                OnErrorsChanged(propertyName);

            }
        }


        private void OnErrorsChanged(string propertyName)
        {
            ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));
        }

        System.Collections.IEnumerable INotifyDataErrorInfo.GetErrors(string? propertyName)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
