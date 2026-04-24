using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Model {
    public interface IExportable {
        // forces classes to include a CSV export method
        string ToCSV();
    }
}