   M S B A M L   `   `   `  ????B  >Binding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:BindingBinding  5   	   7 clr-namespace:Binding.ValidationBinding.Validation  5   	   (    "Binding.ModifProduitWithValidation   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Binding     5   	   7
Validation clr-namespace:Binding.Validation     5   	   -   5          ?Name$
  root??5   	    ? Title$ ModifProduit??5	   
   $	??450??6   $	??450??6,    ? WindowStartupLocation$ CenterScreen=?5
   	    J? CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$! local:CustomCommands.Update??5      5       ? 	Resources 5      .  (Binding.Validation.ListToStringConverter   lstConverter??%   &	          5   
   6+   5      .??5      ??  ?? Orientation$ Vertical=?6   $??25q?6(   .+?5   
   ?? $ 
Horizontal=?6   .+?5      ?? $??Id??6   $	??100??6"   $??5q?61   ?? 5      -   5         ??Name$ TxtBoxId??5      $??5q?5      ${?False??5      ??5      ??  ?? ElementName$
 root??	 ?? Path$	 
Product.Id?5      5       ?? 5"   
   $ 
Horizontal=?6   .+?5$      ?? $??Description??6   $	??100??6+   $??5q?6:   ?? 5&      -   5        
 ??Name$
 TxtBoxDescription??5'      $??5q?5(      $	??100??5)      .??6   ??5*      ?? 5+      $
 root??6   $	 Product.Description?61    ?? UpdateSourceTrigger$ PropertyChanged=?6L    ?? ValidationRules 5,      2  ,Binding.Validation.DescriptionValidationRule  5-      
   Min$ 3??6C   
   Max$ 15??6K   ,  &System.Windows.Controls.ValidationRule   ValidatesOnTargetUpdated$
 True??6T   5/      .??50       51      53      ?? 55   
   -   5        $ TxtBoxDescription_Error??55      
???  ????57      ?? $ TxtBoxDescription??$	 (Validation.Errors)? ?? 	Converter# [  ?? 5<   
   $ 
Horizontal=?6   .+?5>      ?? $
??Prix??6   $	??100??6$   $??5q?63   ?? 5@      -   5        $
 
TxtBoxPrix??5@      $??5q?5E      $	??100??5F      ??5A      ?? $
 root??$	 Product.Prix?$ PropertyChanged=? ?? ValidatesOnExceptions$
 True??5F      5H      ?? 5J   
   -   5        $ TxtBoxPrix_Error??5J      
???  ????5L      ?? $ 
TxtBoxPrix??$	 (Validation.Errors)?# [  ?? 5P   
   -   5         ??Name$ BtnSauvegarder??5P      $??5q?5Q      $??Sauvegarder??5R      $!??local:CustomCommands.Update??5S      5V      5W      