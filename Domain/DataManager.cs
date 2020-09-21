﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MinimalBlog.Domain.Repositories.Abstract;

namespace MinimalBlog.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields { get; set; }
        public IServiceItemsRepository ServiceItems { get; set; }

        public DataManager(ITextFieldsRepository textFieldsRepository, IServiceItemsRepository serviceItemsRepository)
        {
            TextFields = textFieldsRepository;
            ServiceItems = serviceItemsRepository;
        }
    }
}
