   M S B A M L   `   `   `  ?????  ;WSR1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:WSR1.View.WindowsWSR1.View.Windows  5   	       WSR1.View.Windows.AuthWin   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:WSR1.View.Windows     5   	     ? 
ResizeMode$  CanMinimize=?5   	    ? WindowStartupLocation$ CenterScreen=?5	   	   $??Comic Sans MS)?5
   	    ? Title$ Авторизация??5   	   $	??300??6   $	??400??6*    ? Icon$" /Recources/Logo/Ico/icon.ico??66   .??5      ?  ? RowDefinitions 5   
   ?? 5      ?? 5      ?? 5      .+?5   
   ?? $??
Логин??6   $??20q?6#   $??Center=?6/   $??20(?6J    ?? Padding$ 18 0 0 0q?6X   ??5      ?? 5       ?? 
TargetType" ??6   .?5      ??  ?? Property ? y? ?? Value$ 	Collapsed=?63   	 ?? Triggers	 5      ?? 5      
 ?? Binding
 6&   ?? *Text+ ?? ElementName$ tbLogin?? ?? Value  6V   .a?5       ??  ? y?$ Visible=?6=   5!      5#      5%      ?? 5&   
   -   5         ??Name$ tbLogin??5&      $??20q?6#   ?? 5(   
   $??1??6   $??Пароль??6!   $??20q?60   $??Center=?6=   $??20(?6Y   $ 18 0 0 0q?6h   ??5)      ?? 5*      " ??6   .?5+      ??  ? y?$ 	Collapsed=?64   	 5,      ?? 5-      
 6&   ?? *Text+$ tbPass??  6T   .a?5.      ??  ? y?$ Visible=?6<   5/      51      53      ?? 54   
   -   5        $ tbPass??54       $??1??6   $??20q?61   ?? 56   
   -   5         ??Name$ btnEnter??56      $??2??6   $??20q?62   $??
Войти??6W   58      5:      