using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ET
{
    public static class GlobalDefine
    {
        public static bool ILRuntimeMode = true;

        public static bool DevelopMode = true;
        
        private static string s_LoginAddress;

        public static ILog ILog;
        
        public static Options Options;
        
        public static string GetLoginAddress()
        {
            if (GlobalDefine.DevelopMode)
            {
                return "127.0.0.1:10002";
            }
            else
            {
                return s_LoginAddress;
            }
        }

        public static void SetLoginAddress(string loginAddress)
        {
            s_LoginAddress = loginAddress;
        }
    }
}
