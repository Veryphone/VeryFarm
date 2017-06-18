﻿using UnityEngine;
using System.Collections;
using BaPK;

public class New2FontRead : MonoBehaviour {
    public Texture2D textureFont;
    private BitmapFont bitmapFont;
    public Label labelFont;

    private string nameSorttingLayer;
    private int sorttingOrderInLayer;
    private TextAlignment alignment;
    private string value;
    private float kerning;
    private float space;
    private bool isUpdate;
    void Start()
    {
        #region lines for font
      string[] lines = new string[]{
	"61 86 18 22 38 19 A",
	"43 58 18 27 33 19 Á",
	"83 0 18 27 33 19 À",
	"80 114 18 29 31 19 Ả",
	"80 86 18 27 33 19 Ã",
	"79 265 18 26 38 19 Ạ",
	"61 142 18 27 33 19 Ă",
	"60 251 18 32 28 19 Ắ",
	"79 232 18 32 28 19 Ằ",
	"98 254 17 33 27 18 Ẳ",
	"82 32 18 31 29 19 Ẵ",
	"98 199 18 31 33 19 Ặ",
	"62 58 18 27 33 19 Â",
	"61 109 18 32 28 19 Ấ",
	"99 64 17 32 28 18 Ầ",
	"79 198 18 33 27 19 Ẩ",
	"64 0 18 31 29 19 Ẫ",
	"60 219 18 31 33 19 Ậ",
	"269 0 11 22 38 12 E",
	"256 81 11 27 33 12 É",
	"256 53 11 27 33 12 È",
	"256 23 11 29 31 12 Ẻ",
	"256 109 11 27 33 12 Ẽ",
	"256 137 11 26 38 12 Ẹ",
	"268 246 10 27 33 11 Ê",
	"279 154 10 32 28 11 Ế",
	"268 55 11 32 28 12 Ề",
	"268 88 11 33 27 12 Ể",
	"268 122 11 31 29 12 Ễ",
	"268 23 11 31 33 12 Ệ",
	"287 0 4 22 38 5 I",
	"288 47 7 27 33 8 Í",
	"279 233 8 27 33 9 Ì",
	"280 47 7 29 31 8 Ỉ",
	"279 187 9 27 33 10 Ĩ",
	"289 187 4 26 38 5 Ị",
	"98 231 18 22 38 19 O",
	"43 30 19 27 33 20 Ó",
	"23 73 19 27 33 20 Ò",
	"21 105 19 29 31 20 Ỏ",
	"21 163 19 27 33 20 Õ",
	"23 46 19 26 38 20 Ọ",
	"61 170 18 27 33 19 Ô",
	"41 134 19 32 28 20 Ố",
	"41 101 19 32 28 20 Ồ",
	"40 219 19 33 27 20 Ổ",
	"40 253 19 31 29 20 Ỗ",
	"80 144 18 31 33 19 Ộ",
	"41 195 19 23 37 20 Ơ",
	"0 157 20 27 33 21 Ớ",
	"0 105 20 27 33 21 Ờ",
	"24 0 19 29 31 20 Ở",
	"41 167 19 27 33 20 Ỡ",
	"21 135 19 27 37 20 Ợ",
	"151 74 15 22 38 16 Y",
	"150 249 15 27 33 16 Ý",
	"150 221 15 27 33 16 Ỳ",
	"117 169 16 29 31 17 Ỷ",
	"117 199 16 27 33 17 Ỹ",
	"151 97 15 26 38 16 Ỵ",
	"99 150 17 22 38 18 U",
	"133 227 16 27 33 17 Ú",
	"133 255 16 27 33 17 Ù",
	"99 97 17 29 31 18 Ủ",
	"119 23 16 27 33 17 Ũ",
	"134 51 16 26 38 17 Ụ",
	"0 133 20 23 37 21 Ư",
	"0 185 20 27 33 21 Ứ",
	"0 213 20 27 33 21 Ừ",
	"44 0 19 29 31 20 Ử",
	"21 191 19 27 33 20 Ữ",
	"20 241 19 27 37 20 Ự",
	"227 241 13 22 38 14 B",
	"137 0 16 22 38 17 C",
	"136 23 16 22 38 17 D",
	"0 241 19 22 38 20 Đ",
	"268 154 10 22 38 11 F",
	"98 176 18 22 38 19 G",
	"99 127 17 22 38 18 H",
	"268 223 10 22 38 11 J",
	"153 23 15 22 38 16 K",
	"268 200 10 22 38 11 L",
	"0 23 23 22 38 24 M",
	"101 28 17 22 38 18 N",
	"227 195 13 22 38 14 P",
	"0 264 19 22 38 20 Q",
	"227 218 13 22 38 14 R",
	"227 264 13 22 38 14 S",
	"200 0 14 22 38 15 T",
	"134 127 16 22 38 17 V",
	"0 0 23 22 38 24 W",
	"102 0 17 22 38 18 X",
	"134 174 16 22 38 17 Z",
	"151 202 14 17 43 15 a",
	"167 160 15 23 37 16 á",
	"197 266 14 23 37 15 à",
	"197 240 14 25 35 15 ả",
	"169 23 15 22 38 16 ã",
	"197 194 14 21 43 15 ạ",
	"197 171 14 22 38 15 ă",
	"185 0 14 27 33 15 ắ",
	"167 46 15 27 33 16 ằ",
	"183 117 14 29 31 15 ẳ",
	"213 116 14 27 33 15 ẵ",
	"213 89 14 26 38 15 ặ",
	"183 46 14 22 38 15 â",
	"212 201 14 27 33 15 ấ",
	"182 266 14 27 33 15 ầ",
	"167 130 15 29 31 16 ẩ",
	"227 144 14 27 33 15 ẫ",
	"198 28 14 26 38 15 ậ",
	"150 277 15 17 43 16 e",
	"197 216 14 23 37 15 é",
	"183 147 14 23 37 15 è",
	"166 202 15 25 35 16 ẻ",
	"154 0 15 22 38 16 ẽ",
	"81 64 14 21 43 15 ẹ",
	"170 0 14 22 38 15 ê",
	"167 102 15 27 33 16 ế",
	"167 74 15 27 33 16 ề",
	"182 208 14 29 31 15 ể",
	"182 238 14 27 33 15 ễ",
	"151 175 15 26 38 16 ệ",
	"289 23 4 22 38 5 i",
	"280 126 7 23 37 8 í",
	"280 23 8 23 37 9 ì",
	"280 100 7 25 35 8 ỉ",
	"268 177 10 22 38 11 ĩ",
	"288 125 4 26 38 5 ị",
	"213 71 14 17 43 15 o",
	"213 47 14 23 37 15 ó",
	"151 124 15 23 37 16 ò",
	"198 55 14 25 35 15 ỏ",
	"198 81 14 22 38 15 õ",
	"117 227 15 21 43 16 ọ",
	"198 127 14 22 38 15 ô",
	"212 173 14 27 33 15 ố",
	"151 46 15 27 33 16 ồ",
	"212 229 14 29 31 15 ổ",
	"212 259 14 27 33 15 ỗ",
	"151 148 15 26 38 16 ộ",
	"61 198 16 18 42 17 ơ",
	"134 150 16 23 37 17 ớ",
	"134 197 16 23 37 17 ờ",
	"134 101 16 25 35 17 ở",
	"134 78 16 22 38 17 ỡ",
	"120 0 16 22 42 17 ợ",
	"241 172 13 23 43 14 y",
	"255 171 12 29 37 13 ý",
	"241 196 13 29 37 14 ỳ",
	"241 226 13 31 35 14 ỷ",
	"255 201 12 28 38 13 ỹ",
	"242 23 13 23 43 14 ỵ",
	"242 47 13 17 43 14 u",
	"242 65 13 23 37 14 ú",
	"241 258 13 23 37 14 ù",
	"228 45 13 25 35 14 ủ",
	"227 172 13 22 38 14 ũ",
	"228 23 13 21 43 14 ụ",
	"21 219 16 18 42 17 ư",
	"117 145 16 23 37 17 ứ",
	"117 51 16 23 37 17 ừ",
	"116 254 16 25 35 17 ử",
	"117 75 16 22 38 17 ữ",
	"117 122 16 22 42 17 ự",
	"213 23 14 23 37 15 b",
	"185 28 12 17 43 13 c",
	"182 184 14 23 37 15 d",
	"117 98 16 23 37 17 đ",
	"268 274 9 23 37 10 f",
	"183 93 14 23 43 15 g",
	"255 230 12 23 37 13 h",
	"288 233 4 28 38 5 j",
	"255 254 12 23 37 13 k",
	"293 125 3 23 37 4 l",
	"0 87 21 17 43 22 m",
	"242 107 13 17 43 14 n",
	"183 69 14 23 43 15 p",
	"166 228 15 23 43 16 q",
	"279 215 9 17 43 10 r",
	"255 278 12 17 43 13 s",
	"278 274 9 21 39 10 t",
	"242 89 13 17 43 14 v",
	"0 69 22 17 43 23 w",
	"167 184 14 17 43 15 x",
	"198 150 13 17 43 14 z",
	"166 252 15 22 38 16 0",
	"280 77 7 22 38 8 1",
	"242 125 13 22 38 14 2",
	"215 0 13 22 38 14 3",
	"166 275 15 22 38 16 4",
	"242 148 13 22 38 14 5",
	"228 120 13 22 38 14 6",
	"198 104 14 22 38 15 7",
	"212 150 14 22 38 15 8",
	"229 0 13 22 38 14 9",
	"288 262 4 22 38 5 !",
	"228 97 13 22 38 14 ?",
	"43 86 5 8 55 6 ,",
	"43 95 4 5 55 5 .",
	"55 86 4 14 46 5 :",
	"281 0 5 17 46 6 ;",
	"10 287 8 8 38 9 \"",
	"49 86 5 8 38 6 '",
	"228 71 13 25 36 14 $",
	"20 269 19 22 38 20 %",
	"63 32 18 22 38 19 &",
	"288 75 5 24 38 6 (",
	"288 100 5 24 38 6 )",
	"0 292 9 3 50 10 -",
	"80 176 15 16 44 16 +",
	"116 280 16 9 47 17 =",
	"256 0 12 22 38 13 /",
	"290 152 3 23 37 4 |",
	"243 0 12 22 38 13 \\",
	"134 221 15 5 49 16 ~",
	"0 46 22 22 38 23 @",
	"24 30 15 13 38 16 ^",
	"40 285 10 11 38 11 *"
};
        #endregion

        bitmapFont = new BitmapFont(textureFont, lines);
    }

    void Update()
    {
        CreatFont();
    }

    void CreatFont()
    {
        if (isUpdate)
        {
            labelFont.setSortingLayer(nameSorttingLayer);
            labelFont.setSortingOrderInLayer(sorttingOrderInLayer);
            labelFont.setAlignment(alignment);
            labelFont.createLabel(bitmapFont, value, kerning, space);
            isUpdate = false;
        }
    }
    public void New2Read(string nameSorttingLayer, int sorttingOrderInLayer, TextAlignment Alignment,
                       string value, float kerning, float space)
    {
        this.nameSorttingLayer = nameSorttingLayer;
        this.sorttingOrderInLayer = sorttingOrderInLayer;
        this.alignment = Alignment;
        this.value = value;
        this.kerning = kerning;
        this.space = space;
        isUpdate = true;
    }
}
