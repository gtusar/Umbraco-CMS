﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Umbraco.Core;
using Umbraco.Core.Models;
using Umbraco.Web.Models.ContentEditing;

namespace Umbraco.Web.Models.Mapping
{
    public class CodeFileProfile : Profile
    {
        public CodeFileProfile()
        {
            CreateMap<IPartialView, CodeFileDisplay>()
                .ForMember(x => x.FileType, exp => exp.Ignore())
                .ForMember(x => x.Notifications, exp => exp.Ignore())
                .ForMember(x => x.Path, exp => exp.Ignore())
                .ForMember(x => x.Snippet, exp => exp.Ignore());

            CreateMap<Script, CodeFileDisplay>()
                .ForMember(x => x.FileType, exp => exp.Ignore())
                .ForMember(x => x.Notifications, exp => exp.Ignore())
                .ForMember(x => x.Path, exp => exp.Ignore())
                .ForMember(x => x.Snippet, exp => exp.Ignore());

            CreateMap<CodeFileDisplay, IPartialView>()
                .ForMember(x => x.DeletedDate, exp => exp.Ignore())
                .ForMember(x => x.Id, exp => exp.Ignore())
                .ForMember(x => x.Key, exp => exp.Ignore())
                .ForMember(x => x.Path, exp => exp.Ignore())
                .ForMember(x => x.CreateDate, exp => exp.Ignore())
                .ForMember(x => x.UpdateDate, exp => exp.Ignore())
                .ForMember(x => x.Path, exp => exp.Ignore())
                .ForMember(x => x.Alias, exp => exp.Ignore())
                .ForMember(x => x.Name, exp => exp.Ignore())
                .ForMember(x => x.OriginalPath, exp => exp.Ignore())
                .ForMember(x => x.HasIdentity, exp => exp.Ignore());

            CreateMap<CodeFileDisplay, Script>()
                .ForMember(x => x.DeletedDate, exp => exp.Ignore())
                .ForMember(x => x.Id, exp => exp.Ignore())
                .ForMember(x => x.Key, exp => exp.Ignore())
                .ForMember(x => x.Path, exp => exp.Ignore())
                .ForMember(x => x.CreateDate, exp => exp.Ignore())
                .ForMember(x => x.UpdateDate, exp => exp.Ignore())
                .ForMember(x => x.Path, exp => exp.Ignore())
                .ForMember(x => x.Alias, exp => exp.Ignore())
                .ForMember(x => x.Name, exp => exp.Ignore())
                .ForMember(x => x.OriginalPath, exp => exp.Ignore())
                .ForMember(x => x.HasIdentity, exp => exp.Ignore());
        }
    }
}