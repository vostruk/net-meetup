using System;

namespace Starfish.CRM.Organizations.Domain.Common
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class IgnoreMemberAttribute : Attribute
    {
    }
}