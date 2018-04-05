﻿Public Class VotingWindowFor1
    'On Load
    Private Sub VotingWindow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DateTimer.Start()
    End Sub

    'Simulate real time clock
    Private Sub DateTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimer.Tick
        lblDateAndTime.Text = getClock()
    End Sub

    Private Sub btnVote_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVote.Click
        Dim vote_number As Integer

        If Me.radioCandidate1.Checked Then
            vote_number = 0
        ElseIf Me.radioAbstain.Checked Then
            vote_number = 1
        End If

        Voting_System.Vote(vote_number)
    End Sub

    Private Sub Candidate1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pictureBoxCandidate1.Click, lblName1.Click, lblParty1.Click
        Me.radioCandidate1.Checked = True
    End Sub
End Class