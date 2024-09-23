Module Module1

    Sub Main()

        Dim continuar As Boolean = True

        While continuar

            Console.Write("Ingrese el monto de la compra (o escriba salir para cerrar el programa): $")
            Dim input As String = Console.ReadLine()


            If input.ToLower() = "salir" Then
                continuar = False
                Exit While
            End If


            Dim montoCompra As Double

            If Double.TryParse(input, montoCompra) Then
                Dim descuento As Double
                Dim totalPagar As Double


                Select Case montoCompra
                    Case Is >= 1000
                        descuento = 0.3
                    Case Is >= 500
                        descuento = 0.2
                    Case Is >= 250
                        descuento = 0.1
                    Case Else
                        descuento = 0.05

                End Select


                Dim montoDescuento As Double = montoCompra * descuento
                totalPagar = montoCompra - montoDescuento

                Console.WriteLine($"Monto de compra: ${montoCompra}")
                Console.WriteLine($"Descuento aplicado: {descuento * 100}%")
                Console.WriteLine($"Monto del descuento: ${montoDescuento}")
                Console.WriteLine($"Total a pagar: ${totalPagar}")

                Console.ReadKey()

            End If
        End While


















    End Sub

End Module
