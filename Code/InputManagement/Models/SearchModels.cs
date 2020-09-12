using BusinessData.Property;

using InputManagement.Services;
using InputManagement.Property;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InputManagement.Models
{
    public class SearchModels
    {
        OutputOnDbProperty _resultData = new OutputOnDbProperty();
        SearchServices _services = new SearchServices();

        public OutputOnDbProperty SearchSerialInput(SearchSerialInputProperty dataItem)
        {
            _resultData = _services.SearchSerialInput(dataItem);
            return _resultData;
        }

        public OutputOnDbProperty SearchProgressAllProcess(SearchSerialProgressProperty dataItem)
        {
            _resultData = _services.SearchProgressAllProcess(dataItem);
            return _resultData;
        }

        public OutputOnDbProperty SearchCurrentProgress(SearchSerialProgressProperty dataItem)
        {
            _resultData = _services.SearchCurrentProgress(dataItem);
            return _resultData;
        }
        
    }
}