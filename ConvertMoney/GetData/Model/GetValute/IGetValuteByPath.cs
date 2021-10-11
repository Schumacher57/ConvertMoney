using System;
using System.Collections.Generic;
using System.Text;


namespace GetData.Model
{
    interface IGetValuteByPath
    {
        
        DataValute GetListCurrency(string byPath);
        
    }
}
