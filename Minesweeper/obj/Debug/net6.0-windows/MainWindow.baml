   M S B A M L   `   `   `  ????F  BMinesweeper, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:MinesweeperMinesweeper  5   	       Minesweeper.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Minesweeper     5   	     ? Title$  MineSweeper??5   	    ? SizeToContent$ WidthAndHeight=?5	   	   $	??900??5
   	    ? 	Resources 5         	MineImage ?? ImageSource  	TileImage  	FlagImage  
EmptyImage  OneImage  TwoImage  
ThreeImage  	FourImage  	FiveImage 	 SixImage 
 
SevenImage  
EightImage  	TileStyle ?? 
TargetType ?? Property ?? Value ?? 
TargetType??%?  &	        &	 A     &	 ?     &	 ?     &	     &	 E    &	 ?    &	 ?    &	     &		 I    &	
 ?    &	 ?    &	     ?? 5   
   $- 'C:\GIT\Minesweeper\Minesweeper\bomb.png??6'   ?? 5   
   $- 'C:\GIT\Minesweeper\Minesweeper\tile.png??6'   ?? 5   
   $- 'C:\GIT\Minesweeper\Minesweeper\flag.png??6'   ?? 5   
   $. (C:\GIT\Minesweeper\Minesweeper\empty.png??6(   ?? 5   
   $, &C:\GIT\Minesweeper\Minesweeper\one.png??6&   ?? 5   
   $, &C:\GIT\Minesweeper\Minesweeper\two.png??6&   ?? 5   
   $. (C:\GIT\Minesweeper\Minesweeper\three.png??6(   ?? 5   
   $- 'C:\GIT\Minesweeper\Minesweeper\four.png??6'   ?? 5   
   $- 'C:\GIT\Minesweeper\Minesweeper\five.png??6'   ?? 5   
   $, &C:\GIT\Minesweeper\Minesweeper\six.png??6&   ?? 5   
   $. (C:\GIT\Minesweeper\Minesweeper\seven.png??6(   ?? 5   
   $. (C:\GIT\Minesweeper\Minesweeper\eight.png??6(   ?? 5   
   " ??6"   .?5      ??  ? ??
 ?   ?6,   ?? 5       ? ?? 5      ?? 5      " ??6&   .R?5      ? .+?5      ?? #??z??6/   $??Center=?6S   $??Center=?6p   5       5!      5#      5$      5%      .??5&      ? .+?5'   
   ?? -   5         ??Name$
 Easy??5'      $
??Easy??6   $??30??6A   $??50??6M   $
??Left=?6X   $	??Top=?6s   $??0,10,0,0q?6?   ?? 5(   
   -   5        $ Medium??5(      $??Medium??6!   $??30??6G   $??50??6S   $
??Left=?6^   $	??Top=?6y   $??	65,10,0,0q?6?   ?? 5)   
   -   5        	 ??Name$	 
TimePassed??5)      $
??Left=?6)   $	??Top=?6D   $??30??6\   $??50??6h   $??	130,5,0,0q?6s   $
??Bold"?6?   $??28(?6?   
 ?? TextAlignment$
 Center=?6?   06?   ? 5*   
   -   5         ?Name$ gameGrid??5*      $??50,50,50,50q?5+      5.      5/      51      