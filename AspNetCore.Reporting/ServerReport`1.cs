﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore.Reporting
{
    public partial class ServerReport
    {
        //<td class="small-td" style="width:60px"> <button title="Print" id="ssrs_print"><svg xmlns="http://www.w3.org/2000/svg" id="Layer_1" enable-background="new 0 0 32 32" viewBox="0 0 32 32" x="0px" y="0px" width="32px" height="32px" xmlns:xml="http://www.w3.org/XML/1998/namespace" xml:space="preserve" version="1.1"><path clip-rule="evenodd" fill="#333333" fill-rule="evenodd" d="M 22 2 H 10 v 10 h 12 V 2 Z M 30.8 12.15 c 0.233 0.1 0.434 0.25 0.601 0.45 c 0.199 0.167 0.35 0.383 0.449 0.65 C 31.95 13.483 32 13.733 32 14 v 14 h -8 v 4 H 8 v -4 H 0 V 14 c 0 -0.267 0.05 -0.517 0.15 -0.75 c 0.1 -0.267 0.25 -0.483 0.45 -0.65 c 0.167 -0.2 0.383 -0.35 0.65 -0.45 C 1.483 12.05 1.733 12 2 12 h 6 V 0 h 16 v 12 h 6 C 30.267 12 30.533 12.05 30.8 12.15 Z M 5.7 17.7 C 5.5 17.9 5.267 18 5 18 s -0.5 -0.1 -0.7 -0.3 C 4.1 17.5 4 17.267 4 17 s 0.1 -0.5 0.3 -0.7 C 4.5 16.1 4.733 16 5 16 s 0.5 0.1 0.7 0.3 C 5.9 16.5 6 16.733 6 17 S 5.9 17.5 5.7 17.7 Z M 8 26 v -6 h 16 v 6 h 6 V 14 H 2 v 12 H 8 Z M 22 22 H 10 v 8 h 12 V 22 Z" /></svg></button></td><td class="ssrs_h"></td>
        static readonly string TOOL_BAR_STRING;
        //const string TOOL_BAR_STRING = "<table id='ssrs_toolbar'><tr><td class='small-td'><button title='First' id='ssrs_first'></button></td><td class='small-td'><button title='Previous' id='ssrs_prev'></button></td><td style='width:100px;'><input type='text' value='1' id='ssrs_page' />&nbsp;/&nbsp;<span id='ssrs_pageNum'>1</span></td><td class='small-td'> <button title='Next' id='ssrs_next'></button> </td><td class='small-td'> <button title='Last' id='ssrs_last'></button> </td><td class='ssrs_h'></td><td class='small-td' style='width:60px'> <button title='Refresh' id='ssrs_refresh'></button></td><td class='ssrs_h'></td><td class='small-td' style='width:60px'> <button title='Export' id='ssrs_export'></button><div><ul class='ssrs_export_list'><li id='__2'>Word</li><li id='__4'>Excel</li><li id='__6'>PDF</li><li id='__7'>Image</li><li id='__9'>CSV (comma delimited)</li></ul></div> </td><td class='ssrs_h'></td><td class='small-td' style='width:60px'> <button title='Print' id='ssrs_print'></button></td><td class='ssrs_h'></td><td style='width:160px;'><input type='text' value='' id='ssrs_find_text' autocomplete='off' placeholder='Find Text' /></td><td class='small-td showtext'> <button id='ssrs_find_btn' title='Find value in report'>Find</button><td style='width:5px;'>|</td><td class='small-td showtext' style='width:50px;'><button title='Find Next' id='ssrs_find_next'>Next</button></td><td class='ssrs_h'></td><td></td></tr></table>";
        //const string TOOL_BAR_STRING = @"<table id=""ssrs_toolbar""> <tr> <td class=""small-td""> <button title=""First"" id=""ssrs_first""> <svg version=""1.1"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" x=""0px"" y=""0px"" width=""26px"" height=""26px"" viewBox=""-1 0 34 34"" enable-background=""new 0 0 34 34"" xml:space=""preserve""><path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M26,7.85L14.45,16L26,24.15V7.85z M6,4v24H4V4H6z M11,16L28,4v24 L11,16z"" /></svg> </button> </td> <td class=""small-td""> <button title=""Previous"" id=""ssrs_prev""> <svg version=""1.1"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" x=""0px"" y=""0px"" width=""24px"" height=""24px"" viewBox=""0 0 32 32"" enable-background=""new 0 0 32 32"" xml:space=""preserve""><polygon fill-rule=""evenodd"" clip-rule=""evenodd"" points=""23,28 6,16 23,4 23,6.45 9.45,16 23,25.55 "" /></svg> </button> </td> <td style=""width:100px;""><input type=""text"" value=""1"" id=""ssrs_page"" />&nbsp;/&nbsp;<span id=""ssrs_pageNum"">1</span></td> <td class=""small-td""> <button title=""Next"" id=""ssrs_next""> <svg version=""1.1"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" x=""0px"" y=""0px"" width=""24px"" height=""24px"" viewBox=""0 0 32 32"" enable-background=""new 0 0 32 32"" xml:space=""preserve""><polygon fill-rule=""evenodd"" clip-rule=""evenodd"" points=""9,4 26,16 9,28 9,25.55 22.55,16 9,6.45 "" /></svg> </button> </td> <td class=""small-td""> <button title=""Last"" id=""ssrs_last""> <svg version=""1.1"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" x=""0px"" y=""0px"" width=""24px"" height=""24px"" viewBox=""0 0 32 32"" enable-background=""new 0 0 32 32"" xml:space=""preserve""><path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M28,4v24h-2V4H28z M6,24.15L17.55,16L6,7.85V24.15z M21,16L4,28V4 L21,16z"" /></svg> </button> </td> <td class=""ssrs_h""></td> <td class=""small-td"" style=""width:60px""> <button title=""Refresh"" id=""ssrs_refresh""> <svg version=""1.1"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" x=""0px"" y=""0px"" width=""25px"" height=""25px"" viewBox=""-1 0 33 33"" enable-background=""new 0 0 32 32"" xml:space=""preserve""><path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M27.15,7.55c-0.934-1.2-2.017-2.233-3.25-3.1 c-1.267-0.867-2.65-1.517-4.15-1.95l0.5-1.9c1.733,0.467,3.316,1.2,4.75,2.2s2.684,2.184,3.75,3.55c1.033,1.333,1.833,2.833,2.4,4.5 C31.717,12.483,32,14.2,32,16c0,1.467-0.184,2.884-0.55,4.25c-0.4,1.366-0.934,2.65-1.601,3.85c-0.699,1.167-1.533,2.25-2.5,3.25 c-1,0.967-2.083,1.801-3.25,2.5c-1.199,0.667-2.483,1.2-3.85,1.601C18.884,31.816,17.467,32,16,32s-2.883-0.184-4.25-0.55 c-1.367-0.4-2.65-0.934-3.85-1.601c-1.167-0.699-2.233-1.533-3.2-2.5c-1-1-1.833-2.083-2.5-3.25c-0.7-1.199-1.233-2.483-1.6-3.85 C0.2,18.884,0,17.467,0,16s0.2-2.883,0.6-4.25C0.967,10.383,1.517,9.1,2.25,7.9c0.7-1.233,1.567-2.35,2.6-3.35 C5.85,3.55,7,2.7,8.3,2H4V0h8v8h-2V3.35c-1.233,0.6-2.333,1.333-3.3,2.2c-1,0.9-1.85,1.9-2.55,3c-0.667,1.067-1.2,2.25-1.6,3.55 C2.183,13.367,2,14.667,2,16c0,1.267,0.167,2.5,0.5,3.7s0.8,2.316,1.4,3.35c0.633,1.033,1.367,1.983,2.2,2.851 c0.867,0.833,1.816,1.566,2.85,2.199c1.033,0.601,2.15,1.067,3.35,1.4c1.167,0.333,2.4,0.5,3.7,0.5c1.267,0,2.5-0.167,3.7-0.5 s2.316-0.8,3.35-1.4c1.033-0.633,1.983-1.366,2.851-2.199c0.833-0.867,1.566-1.817,2.199-2.851c0.601-1.033,1.067-2.149,1.4-3.35 c0.333-1.167,0.5-2.4,0.5-3.7c0-1.567-0.25-3.067-0.75-4.5C28.75,10.033,28.05,8.717,27.15,7.55z"" /></svg> </button></td> <td class=""ssrs_h""></td> <td class=""small-td"" style=""width:60px""> <button title=""Export"" id=""ssrs_export""> <svg version=""1.1"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" x=""0px"" y=""0px"" width=""24px"" height=""24px"" viewBox=""0 0 32 32"" enable-background=""new 0 0 32 32"" xml:space=""preserve""><path fill-rule=""evenodd"" clip-rule=""evenodd"" d=""M24,4H8v10h16V4z M28.8,2.15c0.233,0.1,0.434,0.25,0.601,0.45 c0.199,0.167,0.35,0.367,0.449,0.6C29.95,3.467,30,3.733,30,4v26H5.6L2,26.4V4c0-0.267,0.05-0.533,0.15-0.8 C2.25,2.967,2.4,2.767,2.6,2.6c0.167-0.2,0.367-0.35,0.6-0.45C3.467,2.05,3.733,2,4,2h24C28.267,2,28.533,2.05,28.8,2.15z M26,16H6 V4H4v21.6L6.4,28H8v-8h14v8h6V4h-2V16z M14,24v4h6v-6H10v6h2v-4H14z"" /></svg><svg xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink"" version=""1.1"" viewBox=""0 0 2048 2048"" height=""24px"" width=""12px"" style=""margin-left:4px;""> <g transform=""matrix(1 0 0 -1 0 2048)""> <path fill=""#333333"" d=""M1024 391l-999 999l121 121l878 -878l878 878l121 -121l-999 -999v0z"" /> </g> </svg> </button><div><ul class=""ssrs_export_list""><li id=""__2"">Word</li><li id=""__4"">Excel</li><li id=""__6"">PDF</li><li id=""__9"">CSV (comma delimited)</li></ul></div> </td> <td class=""ssrs_h""></td> <td style=""width:160px;""><input type=""text"" value="""" id=""ssrs_find_text"" autocomplete=""off"" placeholder='Find Text'/></td> <td class=""small-td showtext""> <button id=""ssrs_find_btn"" title=""Find value in report"">Find</button> <td style=""width:5px;"">|</td> <td class=""small-td showtext"" style=""width:50px;""><button title=""Find Next"" id=""ssrs_find_next"">Next</button></td> <td class=""ssrs_h""></td> <td></td> </tr></table>";
        //<div style=""height:70px;""></div>
        static ServerReport()
        {
            switch (System.Globalization.CultureInfo.CurrentCulture.Name)
            {
                case "zh":
                case "zh-CN":
                case "zh-Hans":
                case "zh-Hans-HK":
                case "zh-Hans-MO":
                case "zh-Hant"://繁体
                case "zh-HK":
                case "zh-MO":
                case "zh-TW":
                case "zh-SG":
                    TOOL_BAR_STRING = "<table id='ssrs_toolbar'><tr><td class='small-td'><button type='button' title='首页' id='ssrs_first'></button></td><td class='small-td'><button type='button' title='上一页' id='ssrs_prev'></button></td><td style='width:100px;'><input type='text' value='1' id='ssrs_page' />&nbsp;/&nbsp;<span id='ssrs_pageNum'>1</span></td><td class='small-td'><button type='button' title='下一页' id='ssrs_next'></button></td><td class='small-td'><button type='button' title='尾页' id='ssrs_last'></button></td><td class='ssrs_h'></td><td class='small-td'><button type='button' title='刷新' id='ssrs_refresh'></button></td><td class='ssrs_h'></td><td class='small-td'><button type='button' title='导出' id='ssrs_export'></button><div><ul class='ssrs_export_list'><li id='__2'>Word文档</li><li id='__4'>Excel表格</li><li id='__6'>PDF文件</li><li id='__7'>图片</li><li id='__9'>CSV文件</li></ul></div></td><td class='ssrs_h'></td><td class='small-td'><button type='button' title='打印' id='ssrs_print'></button></td><td class='ssrs_h'></td><td style='width:160px;'><input type='text' value='' id='ssrs_find_text' autocomplete='off' placeholder='查找' /></td><td class='small-td showtext'><button type='button' id='ssrs_find_btn' title='在报表中查找'>查找</button><td style='width:5px;'>|</td><td class='small-td showtext'><button type='button' title='查找下一个' id='ssrs_find_next'>下一个</button></td><td class='ssrs_h'></td><td></td></tr></table>";
                    break;
                default:
                    TOOL_BAR_STRING = "<table id='ssrs_toolbar'><tr><td class='small-td'><button type='button' title='First Page' id='ssrs_first'></button></td><td class='small-td'><button type='button' title='Previous Page' id='ssrs_prev'></button></td><td style='width:100px;'><input type='text' value='1' id='ssrs_page' />&nbsp;/&nbsp;<span id='ssrs_pageNum'>1</span></td><td class='small-td'><button type='button' title='Next Page' id='ssrs_next'></button></td><td class='small-td'><button type='button' title='Last Page' id='ssrs_last'></button></td><td class='ssrs_h'></td><td class='small-td'><button type='button' title='Refresh Report' id='ssrs_refresh'></button></td><td class='ssrs_h'></td><td class='small-td'><button type='button' title='Export Report' id='ssrs_export'></button><div><ul class='ssrs_export_list'><li id='__2'>Word Document</li><li id='__4'>Excel Sheet</li><li id='__6'>PDF File</li><li id='__7'>Image (TIFF)</li><li id='__9'>CSV File</li></ul></div></td><td class='ssrs_h'></td><td class='small-td'><button type='button' title='Print' id='ssrs_print'></button></td><td class='ssrs_h'></td><td style='width:160px;'><input type='text' value='' id='ssrs_find_text' autocomplete='off' placeholder='Find' /></td><td class='small-td showtext'><button type='button' id='ssrs_find_btn' title='Find In Report'>Find</button><td style='width:5px;'>|</td><td class='small-td showtext'><button type='button' title='Find Next' id='ssrs_find_next'>Next</button></td><td class='ssrs_h'></td><td></td></tr></table>";
                    break;
            }
        }
    }
}
