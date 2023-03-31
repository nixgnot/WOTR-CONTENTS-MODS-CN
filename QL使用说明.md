# QuickLocalization使用详解

+ 本文档为正义之怒MOD外挂汉化工具Quick Localization的使用说明
+ 文档前半部分为使用方式，普通玩家只需要阅读此部分
+ 文档后半部分为运行机制和文件格式，如果有兴趣自行汉化、修改汉化、帮助排错等，可以阅读。

## 目录

- [QuickLocalization使用](#QuickLocalization使用)
  - [我为什么要使用QL](#我为什么要使用QL)
  - [QL不能做什么？](#QL不能做什么？)
  - [QL使用指南](#QL使用指南)
- [进阶：QL运行机制和文件格式](#进阶：QL运行机制和文件格式)
  - [标准语言文件格式](#标准语言文件格式)
  - [官方接口MOD格式](#官方接口MOD格式)
  - [无语言文件的MOD](#无语言文件的MOD)
  - [无语言文件且未开源的MOD](#无语言文件且未开源的MOD)
  - [使用TTT语言接口的MOD](#使用TTT语言接口的MOD)


## QuickLocalization使用
+ Quick Localization（简称QL）是由 **@magicskysword** 制作的一个“外挂式”汉化工具，用于在其他MOD载入后，再外挂载入语言文件
+ 在[这里](https://github.com/nixgnot/WOTR-CONTENTS-MODS-CN/releases)可以找到最新QuickLocalization下载
### 我为什么要使用QL
+ 使用外挂载入的方式，对于**没有语言文件的MOD**也能实现**不需要修改原MOD**即可汉化
+ 汉化文件**不受MOD更新影响**，尤其适合解决使用TTT语言接口的MOD的“**屎山问题**”
+ 各个MOD的汉化文件可以集中在一起，方便管理
+ 可以**不需要重启游戏**就动态重载文本，帮助快速修正汉化错误和确认汉化效果
+ 可以快速修正汉化文本，不需要等待原作者合并汉化文件
+ 仅对游戏文本进行操作，不会对存档、引擎等进行任何修改，兼容性高
### QL不能做什么？
+ 目前对于UMM的游戏内菜单（按ctrl+f10呼出的），QL无法实现汉化
+ 某些代码中写法很特殊的文本，QL无法实现汉化
### QL使用指南
+ **UMM安装**后，找到游戏文件夹下\Mods\QuickLocalization
+ 新建一个**Localization**文件夹和一个**TTTLocalization**文件夹（一般会自动创建，最好确认一下），然后放入汉化文件。
+ 具体汉化文件放入哪个文件夹和MOD本身本地化格式有关。请注意汉化文件的说明。
+ 本文档分享的[汉化文件](https://github.com/nixgnot/WOTR-CONTENTS-MODS-CN/tree/main/QuickLocalization%E7%94%A8%E6%B1%89%E5%8C%96%E6%96%87%E6%9C%AC)都已经放好了对应文件夹，打包下载即可，请勿改变文件结构。

## 进阶：QL运行机制和文件格式
+ QL会自动加载**Localization**和**TTTLocalization**两个文件夹下所有后缀为**JSON**的文件，文件名不会影响加载。
+ 你可以自行改变子文件夹或者文件名来方便自己管理。
+ 特别注意，语言文件的**编码格式**需要为**UTF-8无签名**，否则游戏中会乱码。
+ 下面是想要自制汉化文件和修改汉化文件的说明。你可能会需要以下工具：
   + 加强型文本编辑器，比如**EmEditor**
   + JSON语法检查工具，比如**VScode**或者[在线校验](https://www.sojson.com/)
   + MOD反编译工具，比如[**dnSpy**](https://github.com/dnSpy/dnSpy)
### 标准语言文件格式
本部分适用于**有语言文件**，且使用**标准语言文件**接口的MOD  
典型的代表是[Way of the Shield](https://github.com/nixgnot/WOTR-CONTENTS-MODS-CN#Way-of-the-shield)  
这类MOD在MOD路径下有标准的语言文件，一般在**Localization**文件夹下，**enGB.json**为英文语言文件   
打开后可以很明显看到，"**Key**"是文本的索引，而"**Value**"是文本内容。
实际上通过复制一份**enGB.json**，汉化内容，然后改名为**zhCN.json**即可实现汉化，不需要依赖QL  
```
{

    "strings": [

		{
            "Key": "Empty", 
            "Value": ""
        },
		{
            "Key": "ModifierDescriptor_SoftCover",
            "Value": "Soft Cover"
        },
  ...
  	{
            "Key": "ShieldedMageFeature_Description", 
            "Value": "<i>You have learned how to cast spells from behind the safety of a shield.</i> \n<b>Benefit:</b> You reduce the {g|Encyclopedia:Spell_Fail_Chance}arcane spell failure{/g} of any shield you use by 15% (to a minimum of 0%)."
        },
        
	]	
}
```
也有一些MOD的语言文件是**单个文件**，内容同时包含中文和英文文本  
这里"**Key**"是文本的索引，而"**enGB**"、"**zhCN**"是对应语言的文本内容  
这类MOD可以直接将汉化文本写入"zhCN":后面，如果没有该行，也可以自行增加（注意格式标点）
```
[
  {
    "Key": "DazingAssault.Name",
    "ProcessTemplates": false,
    "enGB": "Dazing Assault",
    "zhCN": "晕眩强袭",
    "ruRu": "Ошеломляющий натиск"
  },
  ...
]
```
+ 有些MOD发布时就自带了语言文件，有一些则需要**运行游戏一次后才会生成**  
+ 但是由于上述优点，依然建议使用QL实现汉化。也可以用QL来实现所见即所得的快速汉化制作汉化文件，然后放在原MOD文件夹使用或者提交作者

要实现此类汉化，Quick Localization所需语言文件格式如下：  
```
[  
  {  
    "Key": "索引1",  
    "zhCN": "汉化文本1",  
  },  
  ...
  {  
    "Key": "索引n",  
    "zhCN": "汉化文本n",  
  }  
]  
```
+ 一目了然，只需要**将“Key”和"zhCN"一一对应**，就能完成汉化。其中Key直接在原语言文件就能找到
+ 请注意汉化文件**最前面和最后面的[]**
+ 一般来说，将原始语言文件**复制一份**进行编辑最为简便。（注意你可能需要**修改文件头尾，或者将"Value"改为"zhCN"供QL识别**）
+ 复制后的文件语言文件可能还有一些额外信息，比如"ProcessTemplates"、"enGB"等，可以**不必理会**。只要不破坏文件格式就不会影响QL识别
+ 你可以在[这里](https://github.com/nixgnot/WOTR-CONTENTS-MODS-CN/tree/main/QuickLocalization%E7%94%A8%E6%B1%89%E5%8C%96%E6%96%87%E6%9C%AC/Localization)找到很多QL语言文件的例子

### 官方接口MOD格式
所谓官方接口MOD，就是指的**非UMM安装**，安装在Locallow文件夹中一类MOD，比如[HomebrewArchetypes](https://github.com/nixgnot/WOTR-CONTENTS-MODS-CN#HomebrewArchetypes)  
这类MOD**全部使用标准语言接口**，可以直接汉化   
也可以使用QL挂载，汉化方法参考上一章节即可  

### 无语言文件的MOD
这类MOD**不会生成语言文件，也不会读取**
但是我们依然可以**使用QL进行外挂汉化**
典型例子如ToggleableThrowingWeapons(https://github.com/nixgnot/WOTR-CONTENTS-MODS-CN#ToggleableThrowingWeapons)  
要汉化此类MOD，你可能需要**少量的编程知识（一丁点就行）**  
在[ToggleableThrowingWeapons的发布页](https://github.com/pheonix99/ToggleableThrowingWeapons)我们能直接看到其源代码文件  
在[ModeSwitching.cs](https://github.com/pheonix99/ToggleableThrowingWeapons/blob/master/ToggleableThrowingWeapons/Content/ModeSwitching.cs)中可以找到下列代码  
```
 var desc = LocalizationTool.CreateString("ThrowWeaponsToggle.Desc", "Use Daggers And Starknives As Ranged Weapons");
            var toglleCOnfig = ActivatableAbilityConfigurator.For(toggleBP).SetDisplayName(LocalizationTool.CreateString("ThrowWeaponsToggle.Name", "Throw Weapons")).SetDescription(desc).SetDescriptionShort(desc);
```
其中，**ThrowWeaponsToggle.Desc**即为**Key**，后面为其文本；下面则是**ThrowWeaponsToggle.Name**及其对应文本。
那么只需要在QL汉化文件中将其一一对应，即可实现汉化，[示例](https://github.com/nixgnot/WOTR-CONTENTS-MODS-CN/blob/main/QuickLocalization%E7%94%A8%E6%B1%89%E5%8C%96%E6%96%87%E6%9C%AC/Localization/ToggleableThrowingWeapons/ToggleableThrowingWeapons.json)  
+ 一般来说，将**MOD源文件**打包下载，然后使用支持多重文件内容搜索的**Powergrep**来查询文本比较迅捷
+ 不同MOD的写法并不一定一致，有的可能会用自行定义的其他方法来调用**CreateString**，甚至用循环变量来生成多条类似的文本，所以需要一定的代码阅读能力

### 无语言文件且未开源的MOD
还有一些MOD，不光没有语言文件，甚至也没有开源  
所幸MOD本身的dll文件都没有加密，所以我们可以使用[反编译软件](https://github.com/dnSpy/dnSpy)直接打开dll文件来阅读代码实现汉化
其实现方式参考上一节
+ 因为dnSpy的分析能力比较好用，我甚至开源也喜欢用他来读代码我会说嘛
+ 本身我dnSpy也不怎么会用，就不在此献丑了

### 使用TTT语言接口的MOD
施工中
