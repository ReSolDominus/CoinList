   M S B A M L   `   `   `  ����C  ?CoinList, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:CoinList.ViewCoinList.View  5   	   9!clr-namespace:CoinList.ViewModelsCoinList.ViewModels  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5	   	       CoinList.View.CoinWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  5   	   'localclr-namespace:CoinList.View  5   	   *vm!clr-namespace:CoinList.ViewModels  5   	   0sys&clr-namespace:System;assembly=mscorlib  5	   	   $	��330��5       $	��425��6-     � Title  6	   �� *Name+*  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5      +  %Microsoft.Xaml.Behaviors.EventTrigger  5   
      	EventName$ Loaded��6   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 6$   �� *WindowLoadedCommand+5       � DataContext 5      S� 5   
    S� 
ObjectType-   'CoinList.ViewModels.CoinWindowViewModel"  6   .��5      � .+�5   
   �� $
��Left=�6   $	��Top=�6/   $��25,5,0,0q�6G   $��30(�6[   $	��375��6i   $��40��6u      ForegroundColor#���   6�   ��6�   �� *Name+�� 5   
   $
��Left=�6   $	��Top=�6/   $��	25,45,0,0q�6G   $��30(�6[   $	��375��6i   $��40��6u   #���   6�   ��6�   �� *CurrentPrice+�� 5   
   $
��Left=�6   $	��Top=�6/   $��	25,85,0,0q�6G   $��30(�6[   $	��375��6i   $��40��6u   #���   6�   $��Price change by time��6�   �� 5   
   $
��Left=�6   $	��Top=�6/   $��
25,130,0,0q�6G   $��24(�6[   $	��375��6i   $��30��6u   #���   6�   ��6�   �� *PriceChangePercentage24Hours+�� 5   
   $
��Left=�6   $	��Top=�6/   $��
25,160,0,0q�6G   $��24(�6[   $	��375��6i   $��30��6u   #���   6�   ��6�   �� *PriceChangePercentage7Days+�� 5   
   $
��Left=�6   $	��Top=�6/   $��
25,190,0,0q�6G   $��24(�6[   $	��375��6i   $��30��6u   #���   6�   ��6�   �� *PriceChangePercentage14Days+�� 5   
   $
��Left=�6   $	��Top=�6/   $��
25,220,0,0q�6G   $��24(�6[   $	��375��6i   $��30��6u   #���   6�   ��6�   �� *PriceChangePercentage30Days+�� 5   
   $
��Left=�6   $	��Top=�6/   $��
25,250,0,0q�6G   $��24(�6[   $	��375��6i   $��30��6u   #���   6�   ��6�   �� *PriceChangePercentage1Year+5       5!      