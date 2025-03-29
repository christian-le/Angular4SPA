using Humanizer;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Angular4SPA.Helpers
{
    public static class VariableNames
    {
        public static string CamelizedName(this ModelExpression modelExpression)
        {
            var className = modelExpression.Metadata.ContainerType.Name;
            var propertyName = modelExpression.Name;

            return className.Camelize() + "." + propertyName.Camelize();
        }        
<<<<<<< HEAD
<<<<<<< HEAD
        
=======
>>>>>>> master
=======
>>>>>>> f41f4f5c6fb1aa95036f16b7f2463bb50b879114
    }
}
