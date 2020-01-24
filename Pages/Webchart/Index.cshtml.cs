using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RazorPagesMovie.Models;
using System.Net.Http;
using System.Net.Http.Headers;

namespace RazorPagesMovie.Pages.Webchart
{

    public class IndexModel : PageModel
    {

        private readonly ILogger<IndexModel> _logger;
        public List<SimpleReportViewModel> lstModelmerchat { get; set; }
        public List<SimpleReportViewModel> lstModelgeopagos { get; set; }
        public List<LogOpeFlow> lstModellogope { get; set; }
        ViewModelDashboard dataGrafico;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public async Task OnGet()
        {

            await CargarDataChart();
        }

          public async Task<bool> CargarDataChart()
        {
            dataGrafico = await Dashboard();
            lstModelmerchat = new List<SimpleReportViewModel>();
            lstModelgeopagos = new List<SimpleReportViewModel>();
            lstModellogope = new List<LogOpeFlow>();

            foreach (var item in dataGrafico.Datamerchant)
            {
                lstModelmerchat.Add(new SimpleReportViewModel
                {
                    DimensionOne = item.Fecha,
                    Quantity = item.Total
                });
            }

             foreach (var item in dataGrafico.Datatrxgeopagos)
            {
                lstModelgeopagos.Add(new SimpleReportViewModel
                {
                    DimensionOne = item.Fecha,
                    Quantity = item.Total
                });
            }


             foreach (var item in dataGrafico.LogOpeFlow)
            {
                lstModellogope.Add(new LogOpeFlow
                {
                    Fecha = item.Fecha,
                    Cliente = item.Cliente,
                    Tipo = item.Tipo,
                    Operacion = item.Operacion,
                    Cant_trx =item.Cant_trx
                });
            }

            return true;
        }

        public async Task<ViewModelDashboard> Dashboard()
        {
            ViewModelDashboard vistadash = new ViewModelDashboard();
            vistadash.Datamerchant = await GetDataMerchant();
            vistadash.Datatrxgeopagos = await GetDataTrxGeopagos();
            vistadash.LogOpeFlow = await GetDataLogOpeFlow();
            return vistadash;
        }

        public async Task<IEnumerable<DataMerchant>> GetDataMerchant()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://flowmanagement.vendemasdev.pe");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.GetAsync("/api/dashboard/TrxFlow");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<IEnumerable<DataMerchant>>();
                }

                return await Task.FromResult<IEnumerable<DataMerchant>>(null);
            }
        }

        public async Task<IEnumerable<DataMerchant>> GetDataTrxGeopagos()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://flowmanagement.vendemasdev.pe");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.GetAsync("/api/dashboard/TrxGeoPagos");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<IEnumerable<DataMerchant>>();
                }

                return await Task.FromResult<IEnumerable<DataMerchant>>(null);
            }
        }

        public async Task<IEnumerable<LogOpeFlow>> GetDataLogOpeFlow()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://flowmanagement.vendemasdev.pe");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                var response = await client.GetAsync("api/dashboard/LogOpeFlow");

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<IEnumerable<LogOpeFlow>>();
                }

                return await Task.FromResult<IEnumerable<LogOpeFlow>>(null);
            }
        }

      


    }
}