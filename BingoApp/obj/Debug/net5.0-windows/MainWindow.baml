   M S B A M L   `   `   `  ����C  ?BingoApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BingoAppBingoApp  5   	       BingoApp.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:BingoApp     5   	     � Title$  
MainWindow��5   	   $	��300��6   $	��400��6)   .��5	      � .+�5
   
   �� $��Número de Bolas��6   $��10,0,10,189q�6,   .��5      � .+�5      �� -   5         ��Name$
 txt1��5      $
��Left=�6(   $��	161,0,0,0q�6C   $��50��6V    �� TextWrapping$
 Wrap=�6`   $��Center=�6t   $��90��6�   �� 5      -   5         ��Name$ slider��5      $
��Left=�6)   $��10,0,0,0q�6D   $��Center=�6V   $	��120��6q    � Maximum$	 100Q�6�    � Value$ 50Q�6�    � Minimum$ 10Q�6�    �� IsSnapToTickEnabled$
 True��6�   �� 5      -   5         ��Name$ 
btnIniciar��5      $��Iniciar��6-   $
��Left=�6?   $��	277,0,0,0q�6Z   $��Center=�6m   $��81��6�   6�   5      5      �� 5   
   -   5        $ 
btnSortear��5      $��Sortear��6%   $
��Left=�67   $��
10,100,0,0q�6R   $	��Top=�6f   $	��101��6~   $	��182��6�   6�   �� 5   
   -   5        $
 txt2��5      $
��Left=�6    $��214,100,0,0q�6;   $��35��6P   $
 Wrap=�6Z   $	��Top=�6n   $	��176��6�   $	��101��6�   $��72(�6�   	 �� 	UndoLimit$		 103��6�   
 �� TextAlignment$
 Center=�6�   �� 5   
   -   5         ��Name$
 txt3��5      $��	Sorteados��6"   $��10,206,10,10q�65   .��5      �� -   5        $ txtSorteados��5      $
��Left=�6,   $��1 - 2 - 3 - 4��6G   $
 Wrap=�6\   $	��370��6p   5      5      5      