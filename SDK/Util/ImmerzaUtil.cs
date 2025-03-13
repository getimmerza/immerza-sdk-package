using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace ImmerzaSDK.Util
{
    public class ImmerzaUtil
    {
        public static string GetHierarchyPath(GameObject obj)
        {
            string path = "/" + obj.name;
            while (obj.transform.parent != null)
            {
                obj = obj.transform.parent.gameObject;
                path = "/" + obj.name + path;
            }

            return path;
        }

        static uint[] table;

        public static uint ComputeChecksum(byte[] bytes)
        {
            uint crc = 0xffffffff;
            for (int i = 0; i < bytes.Length; ++i)
            {
                byte index = (byte)(((crc) & 0xff) ^ bytes[i]);
                crc = (uint)((crc >> 8) ^ table[index]);
            }
            return ~crc;
        }

        public static void InitCrcTable()
        {
            uint poly = 0xedb88320;
            table = new uint[256];
            uint temp = 0;
            for (uint i = 0; i < table.Length; ++i)
            {
                temp = i;
                for (int j = 8; j > 0; --j)
                {
                    if ((temp & 1) == 1)
                    {
                        temp = (uint)((temp >> 1) ^ poly);
                    }
                    else
                    {
                        temp >>= 1;
                    }
                }
                table[i] = temp;
            }
        }

        public static void AddAssetPath(List<string> assetPaths, string path)
        {
            if (!assetPaths.Contains(path))
            {
                assetPaths.Add(path);
            }
        }

        public static void CopyDirectory(string sourcePath, string targetPath)
        {
            foreach (string dirPath in Directory.GetDirectories(sourcePath, "*", SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(dirPath.Replace(sourcePath, targetPath));
            }

            foreach (string newPath in Directory.GetFiles(sourcePath, "*.*", SearchOption.AllDirectories))
            {
                File.Copy(newPath, newPath.Replace(sourcePath, targetPath), true);
            }
        }

        public static bool IsFieldAPrimitiveList(Type type)
        {
            if (!typeof(IList).IsAssignableFrom(type))
            {
                return false;
            }

            if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(List<>))
            {
                return type.GetGenericArguments()[0].IsPrimitive || type.GetGenericArguments()[0].IsAssignableFrom(typeof(string));
            }

            return false;
        }

        public static bool IsFieldAPrimitiveArray(Type type)
        {
            return type.IsArray && (type.GetElementType().IsPrimitive || type.GetElementType().IsAssignableFrom(typeof(string)));
        }

        public static bool IsFieldAReferenceList(Type type)
        {
            if (!typeof(IList).IsAssignableFrom(type))
            {
                return false;
            }

            if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(List<>))
            {
                Type argType =  type.GetGenericArguments()[0];
                return argType.IsClass && argType != typeof(string) && argType.IsSubclassOf(typeof(UnityEngine.Object));
            }

            return false;
        }

        public static bool IsFieldAReferenceArray(Type type)
        {
            return type.IsArray && type.GetElementType().IsClass && type.GetElementType() != typeof(string) && type.GetElementType().IsSubclassOf(typeof(UnityEngine.Object));
        }

#if UNITY_EDITOR
        public static bool IsRunningInPackage()
        {
            return AssetDatabase.IsValidFolder("Packages/com.actimi.immerzasdk");
        }
#endif
    }
}
