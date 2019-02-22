﻿Imports TimboxIntegracion.TimboxLib
Module Module1

    '  This Module Module1 its just by test purposes  
    Sub Main()
        ' Create instance TimboxWebServicesTimbrado & TimboxWebServicesCancelacion
        Dim createRequestTimbrado As TimboxWebServicesTimbrado = Create.createTimbradoRequest(Create.TYPE_TIMBRADO, Create.ENVIRONMENT_STAGING)
        Dim createRequestCancelacion As TimboxWebServicesCancelacion = Create.createCancelacionRequest(Create.TYPE_CANCELACION, Create.ENVIRONMENT_STAGING)

        ' Create a object config type TimboxWebServicesData
        Dim config As New TimboxWebServicesData

        ' Set only static config params
        ' Username & Password
        config.username = "AAA010101000"
        config.password = "h6584D56fVdBbSmmnB"
        ' cer.pem file & key.pem file
        config.cert_pem = My.Computer.FileSystem.ReadAllText("C:\\Users\\raul\\Desktop\\timbox-.net\\ejemplo-.net\\Archivos\\CSD01_AAA010101AAA.cer.pem")
        config.llave_pem = My.Computer.FileSystem.ReadAllText("C:\\Users\\raul\\Desktop\\timbox-.net\\ejemplo-.net\\Archivos\\CSD01_AAA010101AAA.key.pem")

        ' Set the method to test
        Dim method = TimboxMethods.METHOD_CANCELACION_PROCESAR_RESPUESTA

        Select Case method

            Case TimboxMethods.METHOD_TIMBRADO_TIMBRAR_CFDI

                config.xml = "PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0idXRmLTgiPz4KPGNmZGk6Q29tcHJvYmFudGUgeG1sbnM6Y2ZkaT0iaHR0cDovL3d3dy5zYXQuZ29iLm14L2NmZC8zIiB4bWxuczp4c2k9Imh0dHA6Ly93d3cudzMub3JnLzIwMDEvWE1MU2NoZW1hLWluc3RhbmNlIiBWZXJzaW9uPSIzLjMiIHhzaTpzY2hlbWFMb2NhdGlvbj0iaHR0cDovL3d3dy5zYXQuZ29iLm14L2NmZC8zIGh0dHA6Ly93d3cuc2F0LmdvYi5teC9zaXRpb19pbnRlcm5ldC9jZmQvMy9jZmR2MzMueHNkIiBDZXJ0aWZpY2Fkbz0iTUlJRitUQ0NBK0dnQXdJQkFnSVVNekF3TURFd01EQXdNREF6TURBd01qTTNNRGd3RFFZSktvWklodmNOQVFFTEJRQXdnZ0ZtTVNBd0hnWURWUVFEREJkQkxrTXVJRElnWkdVZ2NISjFaV0poY3lnME1EazJLVEV2TUMwR0ExVUVDZ3dtVTJWeWRtbGphVzhnWkdVZ1FXUnRhVzVwYzNSeVlXTnB3N051SUZSeWFXSjFkR0Z5YVdFeE9EQTJCZ05WQkFzTUwwRmtiV2x1YVhOMGNtRmphY096YmlCa1pTQlRaV2QxY21sa1lXUWdaR1VnYkdFZ1NXNW1iM0p0WVdOcHc3TnVNU2t3SndZSktvWklodmNOQVFrQkZocGhjMmx6Ym1WMFFIQnlkV1ZpWVhNdWMyRjBMbWR2WWk1dGVERW1NQ1FHQTFVRUNRd2RRWFl1SUVocFpHRnNaMjhnTnpjc0lFTnZiQzRnUjNWbGNuSmxjbTh4RGpBTUJnTlZCQkVNQlRBMk16QXdNUXN3Q1FZRFZRUUdFd0pOV0RFWk1CY0dBMVVFQ0F3UVJHbHpkSEpwZEc4Z1JtVmtaWEpoYkRFU01CQUdBMVVFQnd3SlEyOTViMkZqdzZGdU1SVXdFd1lEVlFRdEV3eFRRVlE1TnpBM01ERk9Uak14SVRBZkJna3Foa2lHOXcwQkNRSU1FbEpsYzNCdmJuTmhZbXhsT2lCQlEwUk5RVEFlRncweE56QTFNVGd3TXpVME5UWmFGdzB5TVRBMU1UZ3dNelUwTlRaYU1JSGxNU2t3SndZRFZRUURFeUJCUTBORlRTQlRSVkpXU1VOSlQxTWdSVTFRVWtWVFFWSkpRVXhGVXlCVFF6RXBNQ2NHQTFVRUtSTWdRVU5EUlUwZ1UwVlNWa2xEU1U5VElFVk5VRkpGVTBGU1NVRk1SVk1nVTBNeEtUQW5CZ05WQkFvVElFRkRRMFZOSUZORlVsWkpRMGxQVXlCRlRWQlNSVk5CVWtsQlRFVlRJRk5ETVNVd0l3WURWUVF0RXh4QlFVRXdNVEF4TURGQlFVRWdMeUJJUlVkVU56WXhNREF6TkZNeU1SNHdIQVlEVlFRRkV4VWdMeUJJUlVkVU56WXhNREF6VFVSR1VrNU9NRGt4R3pBWkJnTlZCQXNVRWtOVFJEQXhYMEZCUVRBeE1ERXdNVUZCUVRDQ0FTSXdEUVlKS29aSWh2Y05BUUVCQlFBRGdnRVBBRENDQVFvQ2dnRUJBSmRVY3NISUVJZ3dpdnZBYW50R25ZVklPMys3eVRkRDF0a0tvcGJMK3RLU2pSRm8xRXJQZEdKeFAzZ3hUNU8rQUNJRFFYTitIUzl1TVdEWW5hVVJhbFNJRjlDT0ZDZGgvT0gyUG4rVW1rTjRjdWxyMkRhbkt6dFZJTzhpZFhNNmM5YUhuNWhPbzdoRHhYTUMzdU91R1YzRlM0T2JreFRWKzlOc3ZPQVYybE1lMjdTSHJTQjBEaHVMdXJVYlp3WG0rL3I0ZHR6M2IydUxnQmMrRGl5OTVQRytNSXU3b05LTTg5YUJOR2NqVEp3KzlrK1d6SmlQZDNacFFnSWVkWUJEKzhRV3hsWUNneGhudGEzazl5bGdYS1lYQ1lrMGswcWF1dkJKMWpTUlZmNUJqaklVYk9zdGFRcDU5bmtnSGg0NWM5Z253SlJWNjE4TlcwZk1lRHp1S1IwQ0F3RUFBYU1kTUJzd0RBWURWUjBUQVFIL0JBSXdBREFMQmdOVkhROEVCQU1DQnNBd0RRWUpLb1pJaHZjTkFRRUxCUUFEZ2dJQkFCS2owRENOTDFsaDQ0eStPY1dGclQyaWNuS0Y3V3lTT1ZpaHgwb1IrSFByV0tCTVh4bzlLdHJvZG5CMXRnSXg4ZitYanF5cGhoYncranVEU2VEcmI5OVBoQzQrRTZKZVhPa2RRY0p0NTBLeW9kbDlVUnBDVldOV2pVYjNGL3lwYThvVGNmZi9lTWZ0UVpUN01RMUxxaHQreG0zUWhWb3hUSUFTY2UwampzbkJUR0QySlE0dVQzb0NlbThibW9NWFYvZms5YUozdjArWklMNDJNcFk0UE9HVWEvaVRhYXdrbEtSQUwxWGo5SWRJUjA2Uks2OFJTNnhyR2s2andiRFRFS3hKcG1aM1NQTHRsc21QVVRPMWtyYVRQSW85RkNtVS96WmtXR3BkOFpFQUFGdytaZkkrYmRYQmZ2ZER3YU0yaU1HVFFaVFRFZ1U1S0tUSXZrQW5IbzlPNDVTcVNKd3FWOU5MZlBBeENvNWVSUjJPR2liZDlqaEhlODF6VXNwNUdkRTFtWmlTcUpVODJIM2N1NkJpRStEM1liWmVabmpyTlN4QmdLVElmOHcrS05ZUE00YVdudVVNbDBtTGd0T3hUVVhpOU1LblVjY3EzR1pMQTdieDdabjIxMXlQUnFFalNBcXliVU1WSU9obzZhcXprZmMzV0xaNkxuR1UraHlIdVpVZlB3Ym5DbGI3b0ZGejFQbHZHT3BORHNVYjBxUDQyUUNHQmlUVXNlR3VnQXpxT1A2RVlwVlBDNzNnRm91cm1kQlFnZmF5YUV2aTN4ak5hbkZrUGxXMVhFWU5yWUpCNHlOanBoRnJ2V3dUWTg2dkwybzhnWk4wVXRtYzVmbm9CVGZNOXIyelZLbUVpNkZVZUoxaWFEYVZOdjQ3dGU5aVMxYWk0VjR2Qlk4ciIgRmVjaGE9IjIwMTktMDItMThUMTM6MjU6MjEiIEZvcm1hUGFnbz0iMDEiIEx1Z2FyRXhwZWRpY2lvbj0iMDYzMDAiIE1ldG9kb1BhZ289IlBVRSIgTW9uZWRhPSJNWE4iIE5vQ2VydGlmaWNhZG89IjMwMDAxMDAwMDAwMzAwMDIzNzA4IiBTZWxsbz0iWnZRNWZPdm5oVGM2TFFHek81TG43S0NMUWxTVWNhMHlrVWtoSDh4NWczYTZOMzhxSzJ3Z2hqeHBFbHl0NVpENEQ5aXRkU3QxenVFNDJiOTJxMlFrU2JCUkVEMjhVTi9Kb3BndFJHY0xMM1hFWFNObm9lbFRtU0lpWkZGNEN0ektFNXZSRFBYSjhEV0Nja09CMjZobXR3VFNkNHJ3bnFnWUpQbFhWUTZmYVpXQnZPa0IwZTM4MUdNOTFiQ205Z2NYMHdhTnEwWWN1TWtiU3NhM2F5cVYzdzc4WHlIdHl3WHZLMjNRZnhycDVhTElWT01rSFFINmVVd21VNW9nT0pOTDdTWnZTMXFLOVpnTGgrOGlsUVhRS0FnRXhWL00vL000YXFpNnJONVBQTkZLRUg2U0ppTU83L0l2Q2dGd28zeWNtRlNmUWtoaVVXWHoyV01hZlR2NE93PT0iIFN1YlRvdGFsPSIxNTEwLjAwIiBUaXBvQ2FtYmlvPSIxIiBUaXBvRGVDb21wcm9iYW50ZT0iSSIgVG90YWw9IjE3NTEuNjAiPgogIDxjZmRpOkVtaXNvciBSZmM9IkFBQTAxMDEwMUFBQSIgTm9tYnJlPSJTRU5USUVOVCBTQSBERSBDViIgUmVnaW1lbkZpc2NhbD0iNjAxIiAvPgogIDxjZmRpOlJlY2VwdG9yIE5vbWJyZT0iSVQgU1cgRGV2ZWxvcG1lbnQgU29sdXRpb25zIGRlIE1leGljbyBTIGRlIFJMIGRlIENWIiBSZmM9IklBRDEyMTIxNEIzNCIgVXNvQ0ZEST0iUDAxIiAvPgogIDxjZmRpOkNvbmNlcHRvcz4KICAgIDxjZmRpOkNvbmNlcHRvIENhbnRpZGFkPSI1IiBDbGF2ZVByb2RTZXJ2PSIxMDEyMjEwMCIgQ2xhdmVVbmlkYWQ9Ik03NCIgRGVzY3JpcGNpb249IlBydWViYSBDYXRhbG9nb3MgTnVldm9zIiBJbXBvcnRlPSIxMjUwLjAwIiBVbmlkYWQ9IktpbG8iIFZhbG9yVW5pdGFyaW89IjI1MC4wMCI+CiAgICAgIDxjZmRpOkltcHVlc3Rvcz4KICAgICAgICA8Y2ZkaTpUcmFzbGFkb3M+CiAgICAgICAgICA8Y2ZkaTpUcmFzbGFkbyBCYXNlPSIxMjUwLjAwIiBJbXBvcnRlPSIyMDAuMDAiIEltcHVlc3RvPSIwMDIiIFRhc2FPQ3VvdGE9IjAuMTYwMDAwIiBUaXBvRmFjdG9yPSJUYXNhIiAvPgogICAgICAgIDwvY2ZkaTpUcmFzbGFkb3M+CiAgICAgIDwvY2ZkaTpJbXB1ZXN0b3M+CiAgICA8L2NmZGk6Q29uY2VwdG8+CiAgICA8Y2ZkaTpDb25jZXB0byBDYW50aWRhZD0iMSIgQ2xhdmVQcm9kU2Vydj0iMjQxMTE1MDAiIENsYXZlVW5pZGFkPSJLR00iIERlc2NyaXBjaW9uPSJ0cmFzbHVjaWRhIDkweDkwIGNtLiBjYWwuIDIwMCIgSW1wb3J0ZT0iMjIuMDAiIFVuaWRhZD0ia2ciIFZhbG9yVW5pdGFyaW89IjIyLjAwIj4KICAgICAgPGNmZGk6SW1wdWVzdG9zPgogICAgICAgIDxjZmRpOlRyYXNsYWRvcz4KICAgICAgICAgIDxjZmRpOlRyYXNsYWRvIEJhc2U9IjIyLjAwIiBJbXBvcnRlPSIzLjUyIiBJbXB1ZXN0bz0iMDAyIiBUYXNhT0N1b3RhPSIwLjE2MDAwMCIgVGlwb0ZhY3Rvcj0iVGFzYSIgLz4KICAgICAgICA8L2NmZGk6VHJhc2xhZG9zPgogICAgICA8L2NmZGk6SW1wdWVzdG9zPgogICAgPC9jZmRpOkNvbmNlcHRvPgogICAgPGNmZGk6Q29uY2VwdG8gQ2FudGlkYWQ9IjEwIiBDbGF2ZVByb2RTZXJ2PSIxMzEwMTcxMiIgQ2xhdmVVbmlkYWQ9IktHTSIgRGVzY3JpcGNpb249IlBPTElFVElMRU5PIERFIEJBSkEgREVOU0lEQUQiIEltcG9ydGU9IjIzOC4wMCIgVW5pZGFkPSJLRyIgVmFsb3JVbml0YXJpbz0iMjMuODAiPgogICAgICA8Y2ZkaTpJbXB1ZXN0b3M+CiAgICAgICAgPGNmZGk6VHJhc2xhZG9zPgogICAgICAgICAgPGNmZGk6VHJhc2xhZG8gQmFzZT0iMjM4LjAwIiBJbXBvcnRlPSIzOC4wOCIgSW1wdWVzdG89IjAwMiIgVGFzYU9DdW90YT0iMC4xNjAwMDAiIFRpcG9GYWN0b3I9IlRhc2EiIC8+CiAgICAgICAgPC9jZmRpOlRyYXNsYWRvcz4KICAgICAgPC9jZmRpOkltcHVlc3Rvcz4KICAgIDwvY2ZkaTpDb25jZXB0bz4KICA8L2NmZGk6Q29uY2VwdG9zPgogIDxjZmRpOkltcHVlc3RvcyBUb3RhbEltcHVlc3Rvc1RyYXNsYWRhZG9zPSIyNDEuNjAiPgogICAgPGNmZGk6VHJhc2xhZG9zPgogICAgICA8Y2ZkaTpUcmFzbGFkbyBJbXBvcnRlPSIyNDEuNjAiIEltcHVlc3RvPSIwMDIiIFRhc2FPQ3VvdGE9IjAuMTYwMDAwIiBUaXBvRmFjdG9yPSJUYXNhIiAvPgogICAgPC9jZmRpOlRyYXNsYWRvcz4KICA8L2NmZGk6SW1wdWVzdG9zPgo8L2NmZGk6Q29tcHJvYmFudGU+"

                Console.WriteLine(createRequestTimbrado.timbrar(config))

            Case TimboxMethods.METHOD_TIMBRADO_TIMBRAR_CFDI_REFENCIA

                config.xml = "PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0idXRmLTgiPz4KPGNmZGk6Q29tcHJvYmFudGUgeG1sbnM6Y2ZkaT0iaHR0cDovL3d3dy5zYXQuZ29iLm14L2NmZC8zIiB4bWxuczp4c2k9Imh0dHA6Ly93d3cudzMub3JnLzIwMDEvWE1MU2NoZW1hLWluc3RhbmNlIiBWZXJzaW9uPSIzLjMiIHhzaTpzY2hlbWFMb2NhdGlvbj0iaHR0cDovL3d3dy5zYXQuZ29iLm14L2NmZC8zIGh0dHA6Ly93d3cuc2F0LmdvYi5teC9zaXRpb19pbnRlcm5ldC9jZmQvMy9jZmR2MzMueHNkIiBDZXJ0aWZpY2Fkbz0iTUlJRitUQ0NBK0dnQXdJQkFnSVVNekF3TURFd01EQXdNREF6TURBd01qTTNNRGd3RFFZSktvWklodmNOQVFFTEJRQXdnZ0ZtTVNBd0hnWURWUVFEREJkQkxrTXVJRElnWkdVZ2NISjFaV0poY3lnME1EazJLVEV2TUMwR0ExVUVDZ3dtVTJWeWRtbGphVzhnWkdVZ1FXUnRhVzVwYzNSeVlXTnB3N051SUZSeWFXSjFkR0Z5YVdFeE9EQTJCZ05WQkFzTUwwRmtiV2x1YVhOMGNtRmphY096YmlCa1pTQlRaV2QxY21sa1lXUWdaR1VnYkdFZ1NXNW1iM0p0WVdOcHc3TnVNU2t3SndZSktvWklodmNOQVFrQkZocGhjMmx6Ym1WMFFIQnlkV1ZpWVhNdWMyRjBMbWR2WWk1dGVERW1NQ1FHQTFVRUNRd2RRWFl1SUVocFpHRnNaMjhnTnpjc0lFTnZiQzRnUjNWbGNuSmxjbTh4RGpBTUJnTlZCQkVNQlRBMk16QXdNUXN3Q1FZRFZRUUdFd0pOV0RFWk1CY0dBMVVFQ0F3UVJHbHpkSEpwZEc4Z1JtVmtaWEpoYkRFU01CQUdBMVVFQnd3SlEyOTViMkZqdzZGdU1SVXdFd1lEVlFRdEV3eFRRVlE1TnpBM01ERk9Uak14SVRBZkJna3Foa2lHOXcwQkNRSU1FbEpsYzNCdmJuTmhZbXhsT2lCQlEwUk5RVEFlRncweE56QTFNVGd3TXpVME5UWmFGdzB5TVRBMU1UZ3dNelUwTlRaYU1JSGxNU2t3SndZRFZRUURFeUJCUTBORlRTQlRSVkpXU1VOSlQxTWdSVTFRVWtWVFFWSkpRVXhGVXlCVFF6RXBNQ2NHQTFVRUtSTWdRVU5EUlUwZ1UwVlNWa2xEU1U5VElFVk5VRkpGVTBGU1NVRk1SVk1nVTBNeEtUQW5CZ05WQkFvVElFRkRRMFZOSUZORlVsWkpRMGxQVXlCRlRWQlNSVk5CVWtsQlRFVlRJRk5ETVNVd0l3WURWUVF0RXh4QlFVRXdNVEF4TURGQlFVRWdMeUJJUlVkVU56WXhNREF6TkZNeU1SNHdIQVlEVlFRRkV4VWdMeUJJUlVkVU56WXhNREF6VFVSR1VrNU9NRGt4R3pBWkJnTlZCQXNVRWtOVFJEQXhYMEZCUVRBeE1ERXdNVUZCUVRDQ0FTSXdEUVlKS29aSWh2Y05BUUVCQlFBRGdnRVBBRENDQVFvQ2dnRUJBSmRVY3NISUVJZ3dpdnZBYW50R25ZVklPMys3eVRkRDF0a0tvcGJMK3RLU2pSRm8xRXJQZEdKeFAzZ3hUNU8rQUNJRFFYTitIUzl1TVdEWW5hVVJhbFNJRjlDT0ZDZGgvT0gyUG4rVW1rTjRjdWxyMkRhbkt6dFZJTzhpZFhNNmM5YUhuNWhPbzdoRHhYTUMzdU91R1YzRlM0T2JreFRWKzlOc3ZPQVYybE1lMjdTSHJTQjBEaHVMdXJVYlp3WG0rL3I0ZHR6M2IydUxnQmMrRGl5OTVQRytNSXU3b05LTTg5YUJOR2NqVEp3KzlrK1d6SmlQZDNacFFnSWVkWUJEKzhRV3hsWUNneGhudGEzazl5bGdYS1lYQ1lrMGswcWF1dkJKMWpTUlZmNUJqaklVYk9zdGFRcDU5bmtnSGg0NWM5Z253SlJWNjE4TlcwZk1lRHp1S1IwQ0F3RUFBYU1kTUJzd0RBWURWUjBUQVFIL0JBSXdBREFMQmdOVkhROEVCQU1DQnNBd0RRWUpLb1pJaHZjTkFRRUxCUUFEZ2dJQkFCS2owRENOTDFsaDQ0eStPY1dGclQyaWNuS0Y3V3lTT1ZpaHgwb1IrSFByV0tCTVh4bzlLdHJvZG5CMXRnSXg4ZitYanF5cGhoYncranVEU2VEcmI5OVBoQzQrRTZKZVhPa2RRY0p0NTBLeW9kbDlVUnBDVldOV2pVYjNGL3lwYThvVGNmZi9lTWZ0UVpUN01RMUxxaHQreG0zUWhWb3hUSUFTY2UwampzbkJUR0QySlE0dVQzb0NlbThibW9NWFYvZms5YUozdjArWklMNDJNcFk0UE9HVWEvaVRhYXdrbEtSQUwxWGo5SWRJUjA2Uks2OFJTNnhyR2s2andiRFRFS3hKcG1aM1NQTHRsc21QVVRPMWtyYVRQSW85RkNtVS96WmtXR3BkOFpFQUFGdytaZkkrYmRYQmZ2ZER3YU0yaU1HVFFaVFRFZ1U1S0tUSXZrQW5IbzlPNDVTcVNKd3FWOU5MZlBBeENvNWVSUjJPR2liZDlqaEhlODF6VXNwNUdkRTFtWmlTcUpVODJIM2N1NkJpRStEM1liWmVabmpyTlN4QmdLVElmOHcrS05ZUE00YVdudVVNbDBtTGd0T3hUVVhpOU1LblVjY3EzR1pMQTdieDdabjIxMXlQUnFFalNBcXliVU1WSU9obzZhcXprZmMzV0xaNkxuR1UraHlIdVpVZlB3Ym5DbGI3b0ZGejFQbHZHT3BORHNVYjBxUDQyUUNHQmlUVXNlR3VnQXpxT1A2RVlwVlBDNzNnRm91cm1kQlFnZmF5YUV2aTN4ak5hbkZrUGxXMVhFWU5yWUpCNHlOanBoRnJ2V3dUWTg2dkwybzhnWk4wVXRtYzVmbm9CVGZNOXIyelZLbUVpNkZVZUoxaWFEYVZOdjQ3dGU5aVMxYWk0VjR2Qlk4ciIgRmVjaGE9IjIwMTktMDItMThUMTM6MjU6MjEiIEZvcm1hUGFnbz0iMDEiIEx1Z2FyRXhwZWRpY2lvbj0iMDYzMDAiIE1ldG9kb1BhZ289IlBVRSIgTW9uZWRhPSJNWE4iIE5vQ2VydGlmaWNhZG89IjMwMDAxMDAwMDAwMzAwMDIzNzA4IiBTZWxsbz0iWnZRNWZPdm5oVGM2TFFHek81TG43S0NMUWxTVWNhMHlrVWtoSDh4NWczYTZOMzhxSzJ3Z2hqeHBFbHl0NVpENEQ5aXRkU3QxenVFNDJiOTJxMlFrU2JCUkVEMjhVTi9Kb3BndFJHY0xMM1hFWFNObm9lbFRtU0lpWkZGNEN0ektFNXZSRFBYSjhEV0Nja09CMjZobXR3VFNkNHJ3bnFnWUpQbFhWUTZmYVpXQnZPa0IwZTM4MUdNOTFiQ205Z2NYMHdhTnEwWWN1TWtiU3NhM2F5cVYzdzc4WHlIdHl3WHZLMjNRZnhycDVhTElWT01rSFFINmVVd21VNW9nT0pOTDdTWnZTMXFLOVpnTGgrOGlsUVhRS0FnRXhWL00vL000YXFpNnJONVBQTkZLRUg2U0ppTU83L0l2Q2dGd28zeWNtRlNmUWtoaVVXWHoyV01hZlR2NE93PT0iIFN1YlRvdGFsPSIxNTEwLjAwIiBUaXBvQ2FtYmlvPSIxIiBUaXBvRGVDb21wcm9iYW50ZT0iSSIgVG90YWw9IjE3NTEuNjAiPgogIDxjZmRpOkVtaXNvciBSZmM9IkFBQTAxMDEwMUFBQSIgTm9tYnJlPSJTRU5USUVOVCBTQSBERSBDViIgUmVnaW1lbkZpc2NhbD0iNjAxIiAvPgogIDxjZmRpOlJlY2VwdG9yIE5vbWJyZT0iSVQgU1cgRGV2ZWxvcG1lbnQgU29sdXRpb25zIGRlIE1leGljbyBTIGRlIFJMIGRlIENWIiBSZmM9IklBRDEyMTIxNEIzNCIgVXNvQ0ZEST0iUDAxIiAvPgogIDxjZmRpOkNvbmNlcHRvcz4KICAgIDxjZmRpOkNvbmNlcHRvIENhbnRpZGFkPSI1IiBDbGF2ZVByb2RTZXJ2PSIxMDEyMjEwMCIgQ2xhdmVVbmlkYWQ9Ik03NCIgRGVzY3JpcGNpb249IlBydWViYSBDYXRhbG9nb3MgTnVldm9zIiBJbXBvcnRlPSIxMjUwLjAwIiBVbmlkYWQ9IktpbG8iIFZhbG9yVW5pdGFyaW89IjI1MC4wMCI+CiAgICAgIDxjZmRpOkltcHVlc3Rvcz4KICAgICAgICA8Y2ZkaTpUcmFzbGFkb3M+CiAgICAgICAgICA8Y2ZkaTpUcmFzbGFkbyBCYXNlPSIxMjUwLjAwIiBJbXBvcnRlPSIyMDAuMDAiIEltcHVlc3RvPSIwMDIiIFRhc2FPQ3VvdGE9IjAuMTYwMDAwIiBUaXBvRmFjdG9yPSJUYXNhIiAvPgogICAgICAgIDwvY2ZkaTpUcmFzbGFkb3M+CiAgICAgIDwvY2ZkaTpJbXB1ZXN0b3M+CiAgICA8L2NmZGk6Q29uY2VwdG8+CiAgICA8Y2ZkaTpDb25jZXB0byBDYW50aWRhZD0iMSIgQ2xhdmVQcm9kU2Vydj0iMjQxMTE1MDAiIENsYXZlVW5pZGFkPSJLR00iIERlc2NyaXBjaW9uPSJ0cmFzbHVjaWRhIDkweDkwIGNtLiBjYWwuIDIwMCIgSW1wb3J0ZT0iMjIuMDAiIFVuaWRhZD0ia2ciIFZhbG9yVW5pdGFyaW89IjIyLjAwIj4KICAgICAgPGNmZGk6SW1wdWVzdG9zPgogICAgICAgIDxjZmRpOlRyYXNsYWRvcz4KICAgICAgICAgIDxjZmRpOlRyYXNsYWRvIEJhc2U9IjIyLjAwIiBJbXBvcnRlPSIzLjUyIiBJbXB1ZXN0bz0iMDAyIiBUYXNhT0N1b3RhPSIwLjE2MDAwMCIgVGlwb0ZhY3Rvcj0iVGFzYSIgLz4KICAgICAgICA8L2NmZGk6VHJhc2xhZG9zPgogICAgICA8L2NmZGk6SW1wdWVzdG9zPgogICAgPC9jZmRpOkNvbmNlcHRvPgogICAgPGNmZGk6Q29uY2VwdG8gQ2FudGlkYWQ9IjEwIiBDbGF2ZVByb2RTZXJ2PSIxMzEwMTcxMiIgQ2xhdmVVbmlkYWQ9IktHTSIgRGVzY3JpcGNpb249IlBPTElFVElMRU5PIERFIEJBSkEgREVOU0lEQUQiIEltcG9ydGU9IjIzOC4wMCIgVW5pZGFkPSJLRyIgVmFsb3JVbml0YXJpbz0iMjMuODAiPgogICAgICA8Y2ZkaTpJbXB1ZXN0b3M+CiAgICAgICAgPGNmZGk6VHJhc2xhZG9zPgogICAgICAgICAgPGNmZGk6VHJhc2xhZG8gQmFzZT0iMjM4LjAwIiBJbXBvcnRlPSIzOC4wOCIgSW1wdWVzdG89IjAwMiIgVGFzYU9DdW90YT0iMC4xNjAwMDAiIFRpcG9GYWN0b3I9IlRhc2EiIC8+CiAgICAgICAgPC9jZmRpOlRyYXNsYWRvcz4KICAgICAgPC9jZmRpOkltcHVlc3Rvcz4KICAgIDwvY2ZkaTpDb25jZXB0bz4KICA8L2NmZGk6Q29uY2VwdG9zPgogIDxjZmRpOkltcHVlc3RvcyBUb3RhbEltcHVlc3Rvc1RyYXNsYWRhZG9zPSIyNDEuNjAiPgogICAgPGNmZGk6VHJhc2xhZG9zPgogICAgICA8Y2ZkaTpUcmFzbGFkbyBJbXBvcnRlPSIyNDEuNjAiIEltcHVlc3RvPSIwMDIiIFRhc2FPQ3VvdGE9IjAuMTYwMDAwIiBUaXBvRmFjdG9yPSJUYXNhIiAvPgogICAgPC9jZmRpOlRyYXNsYWRvcz4KICA8L2NmZGk6SW1wdWVzdG9zPgo8L2NmZGk6Q29tcHJvYmFudGU+"
                config.external_id = "0123456789"

                Console.WriteLine(createRequestTimbrado.timbrar_referencia(config))

            Case TimboxMethods.METHOD_TIMBRADO_TIMBRAR_ZIP

                config.zipbase64 = "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"

                Console.WriteLine(createRequestTimbrado.timbrar_zip(config))

            Case TimboxMethods.METHOD_TIMBRADO_BUSCAR_CFDIS

                config.rfc_emisor = ""
                config.rfc_receptor = ""
                config.fecha_emision_inicio = ""
                config.fecha_emision_fin = ""
                config.fecha_timbrado_inicio = ""
                config.fecha_timbrado_fin = ""
                config.cancelado = ""
                config.external_id = ""
                config.uuid_id = "406F17E0-C70B-48C3-BF82-5B2C72D0BCEE"
                config.folioid = ""
                config.serie = ""
                config.limit = ""
                config.offset = ""

                Console.WriteLine(createRequestTimbrado.buscar_cfdi(config))

            Case TimboxMethods.METHOD_TIMBRADO_BUSCAR_ACUSE_RECEPCION

                ' Can be Set just one uuid.
                Dim uuid_buscar = New TimboxUuid
                uuid_buscar.uuid = "FFBBA8A8-A1D3-4E3A-9FC4-C883B1A91B712"
                config.uuid = uuid_buscar

                ' Can be set one or more uuids within a List
                Dim lista_uuid_buscar = New List(Of TimboxUuid)
                lista_uuid_buscar.Add(New TimboxUuid() With {.uuid = "406F17E0-C70B-48C3-BF82-5B2C72D0BCEE"})
                lista_uuid_buscar.Add(New TimboxUuid() With {.uuid = "FFBBA8A8-A1D3-4E3A-9FC4-C883B1A91B712"})

                config.uuids = lista_uuid_buscar.ToArray()
                config.fecha_timbrado_inicio = ""
                config.fecha_timbrado_fin = ""

                Console.WriteLine(createRequestTimbrado.buscar_acuse_recepcion(config))

            Case TimboxMethods.METHOD_TIMBRADO_RECUPERAR_COMPROBANTE

                ' Can be set just one uuid.
                Dim uuid_id_recuperar = New TimboxUuid()
                uuid_id_recuperar.uuid = "406F17E0-C70B-48C3-BF82-5B2C72D0BCEE"
                config.uuid = uuid_id_recuperar

                ' Can be set one or more uuids within a List
                Dim lista_uuid_recuperar = New List(Of TimboxUuid)
                lista_uuid_recuperar.Add(New TimboxUuid() With {.uuid = "406F17E0-C70B-48C3-BF82-5B2C72D0BCEE"})
                lista_uuid_recuperar.Add(New TimboxUuid() With {.uuid = "FFBBA8A8-A1D3-4E3A-9FC4-C883B1A91B71"})
                config.uuids = lista_uuid_recuperar.ToArray()

                Console.WriteLine(createRequestTimbrado.recuperar_comprobante(config))

            Case TimboxMethods.METHOD_TIMBRADO_RECUPERAR_COMPROBANTE_REFERENCIA

                ' Can be set just one external_id.
                Dim external_id_recuperar = New TimboxExternal()
                external_id_recuperar.external_id = "123456789"
                config.external = external_id_recuperar

                ' Can be set one Or more external_id within a List
                Dim lista_externals = New List(Of TimboxExternal)
                lista_externals.Add(New TimboxExternal() With {.external_id = "06505796980"})
                lista_externals.Add(New TimboxExternal() With {.external_id = "06505796980"})
                config.externals = lista_externals.ToArray()

                Console.WriteLine(createRequestTimbrado.recuperar_comprobante_referencia(config))

            Case TimboxMethods.METHOD_TIMBRADO_OBTENER_CONSUMO

                Console.WriteLine(createRequestTimbrado.obtener_consumo(config))

            Case TimboxMethods.METHOD_TIMBRADO_CONSULTAR_RFC

                config.rfc = "AAA010101AAA"

                Console.WriteLine(createRequestTimbrado.consultar_rfc(config))

            Case TimboxMethods.METHOD_CANCELACION_CANCELAR_CFDI

                config.rfc_emisor = "AAA010101AAA"
                ' Can be set just one folio.
                Dim folio As New TimboxFolio
                folio.rfc_receptor = "IAD121214B34"
                folio.uuid = "406F17E0-C70B-48C3-BF82-5B2C72D0BCEE"
                folio.total = "7261.60"
                config.folio = folio

                ' Can be set one or more folios within a List.
                Dim folios As New List(Of TimboxFolio)
                folios.Add(New TimboxFolio() With {.uuid = "406F17E0-C70B-48C3-BF82-5B2C72D0BCEE", .rfc_receptor = "IAD121214B34", .total = "7261.60"})
                folios.Add(New TimboxFolio() With {.uuid = "FFBBA8A8-A1D3-4E3A-9FC4-C883B1A91B71", .rfc_receptor = "IAD121214B34", .total = "7261.60"})
                config.folios = folios.ToArray()

                Console.WriteLine(createRequestCancelacion.cancelar(config))

            Case TimboxMethods.METHOD_CANCELACION_CONSULTAR_STATUS

                config.rfc_emisor = "AAA010101AAA"
                config.rfc_receptor = "IAD121214B34"
                config.uuid_id = "406F17E0-C70B-48C3-BF82-5B2C72D0BCEE"
                config.total = "7261.60"

                Console.WriteLine(createRequestCancelacion.consultar_status(config))

            Case TimboxMethods.METHOD_CANCELACION_CONSULTAR_DOCUMENTO_RELACIONADO
                config.uuid_id = "6E5BC378-6EDE-461F-8ABB-F941E19DF4D6"
                config.rfc_receptor = "AAA010101AAA"

                Console.WriteLine(createRequestCancelacion.consultar_documento_relacionado(config))

            Case TimboxMethods.METHOD_CANCELACION_CONSULTAR_PETICIONES_PENDIENTES
                config.rfc_receptor = "AAA010101AAA"

                Console.WriteLine(createRequestCancelacion.consultar_peticiones_pendientes(config))

            Case TimboxMethods.METHOD_CANCELACION_PROCESAR_RESPUESTA
                config.rfc_receptor = "AAA010101AAA"
                ' Can be set just one folio respuesta.
                Dim folio_respuesta As New TimboxRespuesta
                folio_respuesta.rfc_emisor = "IAD121214B34"
                folio_respuesta.uuid = "406F17E0-C70B-48C3-BF82-5B2C72D0BCEE"
                folio_respuesta.total = "7261.60"
                folio_respuesta.respuesta = "A"
                config.respuesta = folio_respuesta

                ' Can be set one or more folio respuesta within a List.
                Dim lista_procesar_respuesta = New List(Of TimboxRespuesta)
                lista_procesar_respuesta.Add(New TimboxRespuesta() With {.uuid = "406F17E0-C70B-48C3-BF82-5B2C72D0BCEE", .rfc_emisor = "AAA010101AAA", .total = "7261.60", .respuesta = "A"})
                lista_procesar_respuesta.Add(New TimboxRespuesta() With {.uuid = "FFBBA8A8-A1D3-4E3A-9FC4-C883B1A91B71", .rfc_emisor = "IAD121214B34", .total = "7261.60", .respuesta = "R"})
                config.respuestas = lista_procesar_respuesta.ToArray()

                Console.WriteLine(createRequestCancelacion.procesar_respuesta(config))

        End Select
        Console.ReadKey(True)

    End Sub

End Module
