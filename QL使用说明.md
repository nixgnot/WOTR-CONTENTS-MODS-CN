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
本部分适用于**有语言文件**，且使用**标准语言文件**接口的MOD  <br>
典型的代表是[Way of the Shield](https://github.com/nixgnot/WOTR-CONTENTS-MODS-CN#Way-of-the-shield)  <br>
这类MOD在MOD路径下有标准的语言文件，一般在**Localization**文件夹下，**enGB.json**为英文语言文件   <br>
打开后可以很明显看到，"**Key**"是文本的索引，而"**Value**"是文本内容<br>
实际上通过复制一份**enGB.json**，汉化内容，然后改名为**zhCN.json**即可实现汉化，不需要依赖QL  <br>
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
也有一些MOD的语言文件是**单个文件**，内容同时包含中文和英文文本  <br>
这里"**Key**"是文本的索引，而"**enGB**"、"**zhCN**"是对应语言的文本内容  <br>
这类MOD可以直接将汉化文本写入"zhCN":后面，如果没有该行，也可以自行增加（注意格式标点）<br>
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
+ 语言文件代码是**大小写敏感**的，请注意不要出错
+ 一般来说，将原始语言文件**复制一份**进行编辑最为简便。（注意你可能需要**修改文件头尾，或者将"Value"改为"zhCN"供QL识别**）
+ 复制后的文件语言文件可能还有一些额外信息，比如"ProcessTemplates"、"enGB"等，可以**不必理会**。只要不破坏文件格式就不会影响QL识别
+ 你可以在[这里](https://github.com/nixgnot/WOTR-CONTENTS-MODS-CN/tree/main/QuickLocalization%E7%94%A8%E6%B1%89%E5%8C%96%E6%96%87%E6%9C%AC/Localization)找到很多QL语言文件的例子
+ 完成汉化文件准备(**注意编码格式用utf-8！**)后，将其放置在 **\Mods\QuickLocalization\Localization** 即可生效
+ 你可以随时修改汉化文件，然后在游戏中Ctrl+F10呼出菜单，在QL中选择重载文本，即可看到更新后效果（可能需要关闭一下游戏中界面再打开）
+ 建议校验一下汉化文件。如果汉化文件格式有误，QL本身也会报错提示错误位置

### 官方接口MOD格式
所谓官方接口MOD，就是指的**非UMM安装**，安装在Locallow文件夹中一类MOD，比如[HomebrewArchetypes](https://github.com/nixgnot/WOTR-CONTENTS-MODS-CN#HomebrewArchetypes)  
这类MOD**全部使用标准语言接口**，可以直接汉化  <br> 
也可以使用QL挂载，汉化方法参考上一章节即可  <br>

### 无语言文件的MOD
这类MOD**不会生成语言文件，也不会读取**<br>
但是我们依然可以**使用QL进行外挂汉化**<br>
典型例子如ToggleableThrowingWeapons(https://github.com/nixgnot/WOTR-CONTENTS-MODS-CN#ToggleableThrowingWeapons)  <br>
要汉化此类MOD，你可能需要**少量的编程知识（一丁点就行）**  <br>
在[ToggleableThrowingWeapons的发布页](https://github.com/pheonix99/ToggleableThrowingWeapons)我们能直接看到其源代码文件  <br>
在[ModeSwitching.cs](https://github.com/pheonix99/ToggleableThrowingWeapons/blob/master/ToggleableThrowingWeapons/Content/ModeSwitching.cs)中可以找到下列代码  <br>
```
 var desc = LocalizationTool.CreateString("ThrowWeaponsToggle.Desc", "Use Daggers And Starknives As Ranged Weapons");
            var toglleCOnfig = ActivatableAbilityConfigurator.For(toggleBP).SetDisplayName(LocalizationTool.CreateString("ThrowWeaponsToggle.Name", "Throw Weapons")).SetDescription(desc).SetDescriptionShort(desc);
```
其中，**ThrowWeaponsToggle.Desc**即为**Key**，后面为其文本；下面则是**ThrowWeaponsToggle.Name**及其对应文本。<br>
那么只需要在QL汉化文件中将其一一对应，即可实现汉化，[示例](https://github.com/nixgnot/WOTR-CONTENTS-MODS-CN/blob/main/QuickLocalization%E7%94%A8%E6%B1%89%E5%8C%96%E6%96%87%E6%9C%AC/Localization/ToggleableThrowingWeapons/ToggleableThrowingWeapons.json)  <br>
+ 一般来说，将**MOD源文件**打包下载，然后使用支持多重文件内容搜索的**Powergrep**来查询文本比较迅捷
+ 不同MOD的写法并不一定一致，有的可能会用自行定义的其他方法来调用**CreateString**，甚至用循环变量来生成多条类似的文本，所以需要一定的代码阅读能力

### 无语言文件且未开源的MOD
还有一些MOD，不光没有语言文件，甚至也没有开源  <br>
所幸MOD本身的dll文件都没有加密，所以我们可以使用[反编译软件](https://github.com/dnSpy/dnSpy)直接打开dll文件来阅读代码实现汉化<br>
其实现方式参考上一节<br>
+ 因为dnSpy的分析能力比较好用，我甚至开源也喜欢用他来读代码我会说嘛
+ 本身我dnSpy也不怎么会用，就不在此献丑了

### 使用TTT语言接口的MOD
有大量基于TTT核心（TabletopTweaks-Core）的MOD（当然也包括TTT本身）使用的是TTT自带的语言系统  <br>
+ 但是并不是说需要TTT核心前置的MOD必定使用该系统<br>
这类MOD都自带语言文件，可以不依赖于QL实现汉化  <br>
但是恕我直言....这个语言系统简直就是**屎山**.....**建议全部改用QL挂载**  <br>
下面这是一个典型的使用TTT语言系统的MOD语言文件<br>
```
{
  "LocalizedStrings": [
    {
      "Key": "f9efdd62ab6e4956b59147e896d33a2f",
      "SimpleName": "AbundantPreparationFeature.Description",
      "ProcessTemplates": true,
      "enGB": "You've learned a way to increase the number of spells you can prepare per day.\nBenefit: You can prepare four more spells per day of 1st, 2nd, and 3rd levels each. This ability only affects arcanist spellbooks.",
      "ruRU": null,
      "deDE": null,
      "frFR": null,
      "zhCN": "你学会了增加每天可以准备的法术数量的方法。\n效果：你可以每天准备4个额外的1、2、3级法术。此能力只作用于奥能师法术书。",
      "esES": null
    },
  ...
  ]
}
```
和之前**标准语言文件格式**不同的是，这里我们需要注意三行  <br>
+ **"Key"** 是前面的**文本索引**
   + 你可能已经注意到，和**标准语言文件格式**不同的是，**TTT文件格式**的Key是一串**数字字母代码**
+ **"SimpleName"** 是MOD作者用来标明这个文本的用处的，此处我们称之为**文本名**
   + 你可能又已经注意到，此处的**文本名**和之前**标准语言文件格式**的 **"Key"** 类似
+ **"zhCN"** 是中文文本

TTT这个语言系统的本意可能是为了避免不同MOD间文本的冲突（比如两个MOD都做了aaa这个专长，但是效果不同，他们的描述 **"Key"** 都是aaa.Description就会导致冲突）  <br>
只要每条文本都拥有一个独立的**代码**，那就完全不会有此问题了  <br>
然而事与愿违，这实际上引起了更大的问题<br>

对于**标准语言文件格式**，直接使用**文本名**作为**Key**，每次MOD更新一般也只会加入新内容，或者偶尔修改一部分老内容<br>
而对于**TTT文件格式**最大的问题就是，不知道什么原理，每次**MOD更新后**，某一文本(比如"魔法飞弹")对应的 **"Key"(代码)** 都会**大量变化**  <br>
甚至不同人安装的MOD，其某一文本对应的 **"Key"(代码)** 都可能会 **不同**  <br>
这就导致每次MOD更新后，之前的**汉化文件都会部分失效**  <br>
由于Key看起来完全就是一串乱码不具备可读性，排查修复起来就会更为困难  <br>
例如旧版是  <br>
```
{
  "LocalizedStrings": [
    {
      "Key": "1112223331001",
      "SimpleName": "MagicMissle.Name",
      "ProcessTemplates": true,
      "enGB": "Magic Missle",
      "zhCN": "魔法飞弹",
    },
  ...
  ]
}
```
新版魔法飞弹对应的文本就可能会变成1112223444555  <br>
那你之前的汉化文件，当然就不能用了  <br>

而这还不是最糟糕的....  <br>
由于MOD汉化者也不可能每次都及时更新，当你更新MOD并启动后，MOD会发现，哎呀语言文件里怎么没有魔法飞弹需要的1112223444555呢....  <br>
没关系！我生成一个！<br>
于是你的语言文件就会变成这样：<br>
```
{
  "LocalizedStrings": [
    {
      "Key": "1112223331001",
      "SimpleName": "MagicMissle.Name",
      "ProcessTemplates": true,
      "enGB": "Magic Missle",
      "zhCN": "魔法飞弹",
    },
    {
      "Key": "1112223444555",
      "SimpleName": "MagicMissle.Name",
      "ProcessTemplates": true,
      "enGB": "Magic Missle",
      "zhCN": null,
    },
  ...
  ]
}
```
由于MOD源代码中并没有中文文本（其实应该做个读取旧文件自动更新的功能，但是TTT作者没做），新生成的文本中没有中文文本，汉化也就失效了  <br>
然后汉化者把1112223444555对应汉化做了后，下次他又变成1112223678909了 😢<br>

时至今日，当你打开[TabletopTweaks-Base](https://github.com/nixgnot/WOTR-CONTENTS-MODS-CN#TabletopTweaks-Base)或者[ExpandedContent2022](https://github.com/nixgnot/WOTR-CONTENTS-MODS-CN#ExpandedContent2022)的语言文件，你就会看到一座货真价实的**屎山**  <br>
大量不同版本的**重复文本**堆积在一起，让原语言文件大了几倍...维护也根本无从下手  <br>
你甚至不知道**哪个Key是对应正确的文本**<br>

所幸现在我们可以用QL**解决这个问题**<br>
特别注意，对于**TTT文件格式** MOD的QL外挂汉化，需要放置路径为 **\Mods\QuickLocalization\TTTLocalization**
其格式如下
```
{
  "ModPath":"***/Localization/LocalizationPack.json",
  "LocalizedStrings": [
    {
      "Key": "1112223331001",
      "SimpleName": "MagicMissle.Name",
      "ProcessTemplates": true,
      "enGB": "Magic Missle",
      "zhCN": "魔法飞弹",
    },
    ...
    ]
}
```
+ 请注意文本两端的{"ModPath":... "LocalizedStrings": [...]}和前述格式的区别
+ **"ModPath"** 中，需要指定 **原MOD语言文件** 的位置，注意是\ 而不是 /
+ 此处的 **"Key"** 、 **"ProcessTemplates"** 、 **"enGB"** 从原文件复制而来，实际不生效，**不需要理会**

在这种模式下，QL的**工作机制有所不同**<br>
QL会先去搜索**原MOD语言文件**，记录下所有 **"SimpleName"(文本名)** 为 **"MagicMissle.Name"** 的文本对应的 **"Key"(代码)**<br>
在上面的例子里，就是1112223331001、1112223444555、1112223678909<br>
随后，QL会将这三个Key**全部替换**为 **QL汉化文件中的汉化文本**<br>

+ 由于MOD更新后，**"SimpleName"(文本名)** 并不会改变，所以可以避免 **"Key"(代码)** 改变导致汉化失效
+ 即使存在重复文本，QL也能完成**全部替换**，防止找不到正确文本

额外说明：某些MOD有一部分文本使用**TTT文件格式**，但是一部分文本没有使用，此处可以混合使用QL两种模式，一部分不指定  **"SimpleName"(文本名)**，直接使用 **"Key"** 完成汉化<br>
[示例](https://github.com/nixgnot/WOTR-CONTENTS-MODS-CN/blob/main/QuickLocalization%E7%94%A8%E6%B1%89%E5%8C%96%E6%96%87%E6%9C%AC/TTTLocalization/TomeOfTheFirebird/TomeOfTheFirebird.json)


**其他存在的问题**<br>
使用QL挂载，能解决大部分**TTT文件格式** ，但是依然存在问题<br>
很容易理解的是，按照这种工作模式，在 **QL汉化文件** 中不能存在重复的 **"SimpleName"(文本名)**（实际上会识别第一条文本并报错，但是可以正常读取） <br>
如果你复制 **原MOD语言文件** 来制作  **QL汉化文件** ,你需要手动删除重复的**屎山文本** 来防止报错  <br>

但是，有些MOD，在 **原MOD语言文件** 就存在，**并不是同一个文本** 但是 **"SimpleName"(文本名)** 相同的情况<br>
其中大部分是原作者写错了，少部分是写法不规范故意为之<br>
对于这种文本，如果使用 **QL汉化文件** 会导致**所有文本都被统一成一个** ，影响使用<br>
+ 此处建议有二种解决办法
   + 如果不需要汉化（原MOD已有），可以在 **QL汉化文件** 中删除对应字段，使用**原MOD语言文件**
   + 如果需要汉化或对文本进行修改，可以在 **QL汉化文件** 中 **不指定SimpleName** ，直接使用**原MOD语言文件** 中查询获得的 **"Key"(一串代码数字)** 进行汉化，但是版本更新后依然需要修改





