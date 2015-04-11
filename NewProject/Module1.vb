Option Strict On
Imports System.Console

Module Module1

    Sub Main()
        Const TOTAL_GRADES As Double = 10

        Dim selection As String = ""
        Dim svalueOne As String = ""
        Dim svalueTwo As String = ""

        Dim valueOne As Double = 0
        Dim valueTwo As Double = 0
        Dim tempNunber As Double = 0
        Dim difference As Double = 0

        Dim sgrade As String = ""

        Dim grade As Double = 0

        Dim totalPoints As Double

        Dim average As Double = 0

        Dim counter As Integer = 0


        selection = InputBox("There are two features in this program. Please select a feature by entering 1 or 2")

        'check user selection
        If (selection = "1") Then
            WriteLine("You chose feature 1")
            WriteLine("")

            'go into feature one, request first number and turn it into a double
            svalueOne = InputBox("Please enter a positive number")
            valueOne = Val(svalueOne)

            ' check if valueOne is positive
            If (valueOne > 0) Then
                WriteLine("For your first number, you entered: " & valueOne)
                WriteLine("")

                'nested if statement, request a second number and turn it into a double
                svalueTwo = InputBox("Please enter a second positive number")
                valueTwo = Val(svalueTwo)

                'check to see if valueTwo is positive
                If (valueTwo > 0) Then
                    WriteLine("For your second number, you entered: " & valueTwo)
                    WriteLine("")


                    If (valueOne > valueTwo) Then
                        ' valueOne is larger. switch values so that a negative number is not produced. make valueTwo the larger number
                        tempNunber = valueTwo 'smaller value placed in temp
                        valueTwo = valueOne   'larger value placed in valueTwo
                        valueOne = tempNunber   'temp number

                        WriteLine("New valueOne = " & valueOne & ". New valueTwo = " & valueTwo)
                        WriteLine("")


                    ElseIf (valueTwo > valueOne) Then
                        WriteLine("valueOne = " & valueOne & ". valueTwo = " & valueTwo)
                        WriteLine("")

                    End If

                    'calculate difference
                    difference = valueTwo - valueOne

                    'display difference
                    WriteLine("The difference between your two numbers " & valueTwo & " and " & valueOne & " is: " & difference)
                    ReadLine()

                Else
                    'invalid choice
                    WriteLine("Error. You did not enter a second positive number. You entered: " & valueTwo)

                End If

            Else
                'invalid choice
                WriteLine("Error. You did not enter a positive number. You entered: " & valueOne)

            End If

            ' go into feature 2
        ElseIf (selection = "2") Then
            WriteLine("You chose feature 2")
           

            'request grades 1-10 from user
            While (counter < 10)
                sgrade = InputBox("Please enter a grade")
                grade = Val(sgrade)
                totalPoints = totalPoints + grade
                counter += 1
                WriteLine("Grade " & counter & ": " & grade)
            End While

            'calculate average
            average = totalPoints / TOTAL_GRADES

            'display total point and average
            WriteLine("Total Points: " & totalPoints)
            WriteLine("Average: " & average)

            'assign letter grade
            Select Case average
                Case 90 To 100
                    WriteLine("Letter Grade: A")
                Case 80 To 89
                    WriteLine("Letter Grade: B")
                Case 70 To 79
                    WriteLine("Letter Grade: C")
                Case 60 To 69
                    WriteLine("Letter Grade: D")
                Case 0 To 59
                    WriteLine("Letter Grade: F")

            End Select

            ReadLine()

        Else
            'invalid choice
            WriteLine("You did not make a valid choice")
        End If

        ReadLine()

    End Sub

End Module
