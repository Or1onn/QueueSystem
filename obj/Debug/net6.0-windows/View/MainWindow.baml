   M S B A M L   `   `   `  ????  QueueSystem    QueueSystem.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Bd4http://schemas.microsoft.com/expression/blRight/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Gthemes4http://schemas.actiprosoftware.com/winfx/xaml/themes     5   	     ? WindowStartupLocation$  CenterScreen=?5       ? WindowStyle$
 None=?6?    ? 
ResizeMode$ CanMinimize=?6R    ? Title$ 
MainWindow??5   	   $	??700??6   $
??1200??6)   $	??450??66   $	??800??6F    ? 	Resources 5
         RectBorderStyle ?? 
TargetType ?? Property ?? Value ?? RelativeSource	 ?? AncestorType??%?   &	        ?? 5   
   " ??6(   .?5      ??  ? |?$ False??6*   ?? 5       ? ??
 ???? 6%   ?? 5       ?@?Tag 6$   ??  ?? 
	 Window-   5        5      5      .??5      ? .+?5   
   ? -   5        $	??Top=?5   1   $??0q?6I   ???#303030
 ? ColumnDefinitions
 5      ?? 5      $
??Auto ?6#   ?? 5      $??* ?6#   ?? 5      $
??Auto ?6#   .+?5      ?? -   5         ??Name$ 
HeaderIcon??5      $??0??6(   $??20??68   $??20??6C   $??
5, 4, 5, 4q?6O   $
??Left=?6c   ?? 5      -   5         ??Name$ HeaderTitle??5      $??1??6-   $??5q?6=    ?? TextAlignment$
 Left=?6H   ???#FFFFFF$??13(?6r   $
??Left=?6?   ?? 5      $??2??6   $	??Top=?6)    ?? Orientation$ 
Horizontal=?6B   $??Right=?6[   .+?5      ?? -   5         ??Name$ MinimizeButton??5        MinimizeButtonStyle#???  61   -  'System.Windows.Input.KeyboardNavigation   	IsTabStop$ False??6v   ?? 5      -   5        $ MaximizeButton??5        MaximizeButtonStyle#???  61   $ False??6u   ?? 5       -   5        $ CloseButton??5         CloseButtonStyle#???  6/   $ False??6t   5!      5"      ? 5#   
   $??0,30,0,0q?6   $??Stretch=?6"   $??Stretch=?6>   .+?5$      ? 
 5%      ?? 5&      ?? 5'       ? RowDefinitions 5*      ?? 5+      $??80 ?6$   ?? 5,      $??0.15* ?6%   ?? 5-      ?? 5.      $
??0.2* ?6$   .+?51      ?? $??2??6   ???#23232361   ?? 54      $??Bottom=?6   $??
20,10,20,0q?69   $??2??6M   $??1??6a   .+?55      ? $??0,10,0,0q?6   
 56      ?? 57      $??60 ?6/   ?? 58      $??1* ?6/   ?? 59      $??1* ?6/   ?? 5:      $??1* ?6/   ?? 5;      $
??0.5* ?6/   .+?5=      ?? $??0??6!   ???#000$??15(?6C   $??Stretch=?6R   $??Center=?6p   $??Növbə??5>   (   $	??TeX)?69   $??Center=?6J   $
??Bold"?6e   ?? 5@      $??1??6!   ???#000$??15(?6D   $??Center=?6S   $??Stretch=?6n   $??Center=?6?   $	??FIN??5A   (   $??TeX_Bold)?67   $
??Bold"?6M   ?? 5C      $??2??6!   ???#000$??15(?6D   $??Center=?6S   $??Stretch=?6n   $??Center=?6?   $??Tam adı??5D   (   $??TeX_Bold)?6;   $
??Bold"?6Q   ?? 5F      $??3??6!   ???#000$??15(?6D   $??Center=?6S   $??Stretch=?6n   $??Center=?6?   $??Ödəniş Statusu??5G   (   $??TeX_Bold)?6B   $
??Bold"?6X   ?? 5J      $??4??6!   ???#000$??15(?6D   $??Center=?6S   $??Stretch=?6n   $??Center=?6?   $??
Düzəliş??5K   (   $??TeX_Bold)?6:   $
??Bold"?6P   5M      5N      ?? 5Q      ???#2d2d2d$??0??6/    ? Cursor$  ??6<   $??2??6F   $??0q?6Z    ?? CornerRadius$ 6??6n   $??Center=?6   $	??500??6?   $??40??6?   $??0,0,0,0q?6?   ._?5R      ?? -   5         ??Name$ 	SearchBar??5R   C     placeHolder#??[ 6   
 ? Tag$ Axtar??6V   $??16(?6b   $??0q?6p   ???#2d2d2d???#E5E5E5$??	10,0,10,0q?6?   $??Center=?6?   5S      ?? 5U      -	   5         ??Name$
 list??5U        ListViewContainerStyle#??[ 6*   $??Stretch=?6g   $??
20,10,20,0q?6?   $??2??6?   $??2??6?   $??Stretch=?6?   $??1q?6?   $??0q?6?   
?????? ???#F0F0F0??5V      ?? 5W      .R?5X      ?? $ 8??6%   $??2q?66   ???#ffcb74._?5Y   "   ?? .??5Z   &   ?? 67   5[   #   5]      5^      ??5`      ?? 5a      .R?5b      ? $??0,10,0,0q?6#   
 5c   "   ?? 5d   &   $??55 ?67   ?? 5e   &   $??1* ?67   ?? 5f   &   $??1* ?67   ?? 5g   &   $??1* ?67   ?? 5h   &   $
??0.5* ?67   .+?5k   "   ?? $??0??6(   ???#000$??18(?6J   $??Center=?6Y   $	??TeX)?5l   C   $??Center=?6T   $
??Bold"?6o   ??6(   ?? *Queue+6o   ?? 5n   "   $??1??6(   ???#000$??18(?6J   $??Center=?6X   $??Center=?6t   $	??TeX)?5o   A   ??6(   ?? *FIN+6A   ?? 5q   "   $??2??6(   ???#000$??18(?6K   $??Center=?6Z   $??Center=?6u   $??TeX_Bold)?5r   F   $
??Bold"?6\   ??6(   ?? *
FullName+6\   ?? 5u   "    ??Name$ 	PayBorder??6)   $??3??6<   $	??130??6L   $??40??6X   $??1q?5v   1   $ 20??6E   $??Center=?5w   1   ._?5y   &   ??  ??Name$ PayLabel??6,   $??17(?6>   ???#000$??Center=?5z   a   $	??TeX)?5{   4   $??Center=?5|   4   ??5z   4   ?? *IsPaid+5}   '   5~   #   ?? 5?   "   $ stack2??6p   -
   5          AnimationButton#??[ 5?   )   $
 Hand??6R   $??4??6`   $??0q?6?   ???#3740DF$??50??5?   1   $??50??6<   $
??Left=?6H   $??Center=?6c    6~   ?? *Queue+ 5?   &   ??%^   '??       ?? 5?   *   " ??60   .?5?   .   ??  ?@??CornerRadius$ 8??6M   5?   +   5?   '   .??5?   &   ??   page_editDrawingImage#??[ 6,   $??40??6\   $??40??6h   $??Center=?6s   z?5?   &   ?? 5?   *   5?   #   ?? 5?   "   -   5        #??[ 5?   )   $
 Hand??6R   $??4??6`   $??0q?6q   ???#232323$??0,0,10,0q?6?   $??50??5?   !   $??50??6,   $??Right=?68   $??Center=?6T    5?   !   ?? *Queue+ 5?   &   ??%^   '??       ?? 5?   *   " ??60   .?5?   .   ??  ?@??CornerRadius$ 8??6M   5?   +   5?   '   .??5?   &   ??   trashDrawingImage#??[ 6,   $??40??6X   $??40??6d   $??Center=?6o   z?5?   &   ?? 5?   *   5?   #   5?       ?? Triggers 5?      ?? 5?   "    ?? Value$
 true??6N    ?? Binding 6.   ??  ?? Path$ IsPaid?.a?5?   &   ??  ?? 
TargetName$ PayLabel??6-    ? ??$ 
Ödənilib??6V   ?? 5?   &   $ PayLabel??6-    ? ??
 ? ? ?6Y   5?   #   ?? 5?   "   $ false??6N    6.   ?? $ IsPaid?.a?5?   &   ?? $ PayLabel??6-    ? ??$ Ödənilməyib??6V   ?? 5?   &   $ PayLabel??6-    ? ??
 ?  ??6Y   5?   #   ?? 5?   "   $
 true??6N    6.   ?? $ IsPaid?.a?5?   &   ?? $ 	PayBorder??6-    ? ??
 ? ? ?6[   5?   #   ?? 5?   "   $ false??6N    6.   ?? $ IsPaid?.a?5?   &   ?? $ 	PayBorder??6-    ? ??
 ?  ??6[   5?   #   5?      5?      ?? 5?      -   5        $ stack2??5?   q   #??[ 6   $
 Hand??6B   $??2??6P   $??3??6d   $??0q?6?   ???#ffa70f$??50??5?   1   $??50??6<   $??Center=?6I    5?      ??%^   '??       ?? 5?      " ??6    .?5?      ??  ?@??CornerRadius$ 8??6=   5?      5?      .??5?      ??  	 plusDrawingImage#??[	 6   $??40??6G   $??40??6S   $??Center=?6^   z?5?      ?? 5?      5?      ?? 5?      -   5        #??[ 5?      $
 Hand??6B   $??1??6P   $??3??6`   $??Right=?6m   $??0q?6?   ???#232323$??0,0,20,0q?6?   $??50??5?   1   $??50??6<   $??Center=?6H    5?      ??%^   '??       ?? 5?      " ??6    .?5?      ??  ?@??CornerRadius$ 8??6=   5?      5?      .??5?      ?? #??[ 6   $??40??6H   $??40??6T   $??Center=?6_   z?5?      ?? 5?      5?      5?      5?      ?? 5?   
   -   5         ??Name$ leftSizeGrip??5?      $??7??6*   $
??Left=?64   $ SizeWE??6O   #??[  6_   ?? 5?   
   -   5        $ rightSizeGrip??5?      $??7??6+   $??Right=?65   $ SizeWE??6Q   #??[  6a   ?? 5?   
   -   5        $ topSizeGrip??5?      $??7??6)   $	??Top=?64   $ SizeNS??6L   #??[  6\   ?? 5?   
   -   5        $ bottomSizeGrip??5?      $??7??6,   $??Bottom=?67   $ SizeNS??6R   #??[  6b   ?? 5?   
   -   5        $??topLeftSizeGrip??5?      $??7??6+   $??7??65   $
??Left=?6@   $	??Top=?6[   $ SizeNWSE??6s   #??[  6?   ?? 5?   
   -   5        $??bottomRightSizeGrip??5?      $??7??6/   $??7??69   $??Right=?6D   $??Bottom=?6`   $ SizeNWSE??6{   #??[  6?   ?? 5?   
   -   5        $??topRightSizeGrip??5?      $??7??6,   $??7??66   $??Right=?6A   $	??Top=?6]   $ SizeNESW??6u   #??[  6?   ?? 5?   
   -   5        $??bottomLeftSizeGrip??5?      $??7??6.   $??7??68   $
??Left=?6C   $??Bottom=?6^   $ SizeNESW??6y   #??[  6?   5?      5?      