   M S B A M L   `   `   `  ????B  >Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:BindingBinding  5   	       Binding.ModifProduit   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Binding     5   	   -   5          ?Name$
  root??5
   	    ? Title$ ModifProduit??5   	   $	??450??6   $	??450??6+    ? WindowStartupLocation$ CenterScreen=?5	   	   .??5      ??  ?? Orientation$ Vertical=?6   $??25q?6(   .+?5   
   ?? $ 
Horizontal=?6   .+?5      ?? $??Id??6   $	??100??6"   $??5q?61   ?? 5      -   5         ??Name$ TxtBoxId??5      $??5q?5      ${?False??5      ??5      ??  ?? ElementName$
 root?? ?? Path$ 
Product.Id?5      5      ?? 5   
   $ 
Horizontal=?6   .+?5      ?? $??Description??6   $	??100??6+   $??5q?6:   ?? 5      -   5         ??Name$ TxtBoxDescription??5      $??5q?5      $	??100??5       ??5      ?? $
 root??$ Product.Description? ?? UpdateSourceTrigger$ PropertyChanged=?5       5"      ?? 5$   
   $ 
Horizontal=?6   .+?5&      ?? $
??Prix??6   $	??100??6$   $??5q?63   ?? 5(      -   5        $ 
TxtBoxPrix??5(      $??5q?5*      $	??100??5+      ??5)      ?? $
 root??$ Product.Prix?$ PropertyChanged=?5+      5-      ?? 5/   
   -   5        	 ??Name$	 BtnSauvegarder??5/      $??5q?50      $??Sauvegarder??51      52      55      56      