﻿using Senparc.CO2NET.Cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Senparc.NeuChar.Cache
{
    /// <summary>
    /// Container的领域缓存策略定义
    /// </summary>
    public class ContainerCacheStrategyDomain : ICacheStrategyDomain
    {

        #region 单例

        /// <summary>
        /// LocalCacheStrategy的构造函数
        /// </summary>
        ContainerCacheStrategyDomain() : base()
        {
        }

        //静态LocalCacheStrategy
        public static ICacheStrategyDomain Instance
        {
            get
            {
                return Nested.instance;//返回Nested类中的静态成员instance
            }
        }


        class Nested
        {
            static Nested()
            {
            }
            //将instance设为一个初始化的LocalCacheStrategy新实例
            internal static readonly ContainerCacheStrategyDomain instance = new ContainerCacheStrategyDomain();
        }

        #endregion

        private const string IDENTITY_NAME= "0EEBB862-276C-4546-9964-FF9733EBD36B";//固定值，请勿修改
        private const string DOMAIN_NAME = "ToutiaoContainer";//固定值，请勿修改。同时会作为缓存键命名空间的子级名称

        public string IdentityName { get { return IDENTITY_NAME; } }

        public string DomainName { get { return DOMAIN_NAME; } }
    }
}
