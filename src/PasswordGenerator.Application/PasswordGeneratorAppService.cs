using System;
using System.Collections.Generic;
using System.Text;
using PasswordGenerator.Localization;
using Volo.Abp.Application.Services;

namespace PasswordGenerator;

/* Inherit your application services from this class.
 */
public abstract class PasswordGeneratorAppService : ApplicationService
{
    protected PasswordGeneratorAppService()
    {
        LocalizationResource = typeof(PasswordGeneratorResource);
    }
}
