﻿using System.Web.Mvc;
using MvcMenuNavigator.NavigationMenu;

namespace MvcMenuNavigator
{
    public class MenuNavigator : ActionFilterAttribute, IActionFilter
    {
        private readonly HeaderTop _headerTop;
        private readonly HeaderSub _headerSub;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="headerTop">Main Menu</param>
        /// <param name="headerSub">Sub Menu</param>
        public MenuNavigator(HeaderTop headerTop, HeaderSub headerSub)
        {
            _headerTop = headerTop;
            _headerSub = headerSub;
        }

        void IActionFilter.OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.Controller.TempData["MvcMenuNavigator.HeaderTop"] = _headerTop;
            filterContext.Controller.TempData["MvcMenuNavigator.HeaderSub"] = _headerSub;
            
            OnActionExecuting(filterContext);
        }
    }
}
