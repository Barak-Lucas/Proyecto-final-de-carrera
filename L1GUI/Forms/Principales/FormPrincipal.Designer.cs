namespace L1GUI
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            gestionDeClientesToolStripMenuItem = new ToolStripMenuItem();
            carteraDeClientesToolStripMenuItem = new ToolStripMenuItem();
            registroDeInteraccionesToolStripMenuItem = new ToolStripMenuItem();
            calendarioDeVisitasToolStripMenuItem1 = new ToolStripMenuItem();
            gestionDeInmueblesToolStripMenuItem = new ToolStripMenuItem();
            propiedadesToolStripMenuItem = new ToolStripMenuItem();
            catalogoDePropiedadesToolStripMenuItem = new ToolStripMenuItem();
            aBMDePropiedadesToolStripMenuItem = new ToolStripMenuItem();
            contratosToolStripMenuItem = new ToolStripMenuItem();
            estadoToolStripMenuItem = new ToolStripMenuItem();
            gestionAdministrativaToolStripMenuItem = new ToolStripMenuItem();
            registrarVentaToolStripMenuItem = new ToolStripMenuItem();
            calendarioDeTasacionesToolStripMenuItem = new ToolStripMenuItem();
            reimprimirTasacionesToolStripMenuItem = new ToolStripMenuItem();
            gestionDeReportesToolStripMenuItem = new ToolStripMenuItem();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            gestionDePermisosToolStripMenuItem = new ToolStripMenuItem();
            backupToolStripMenuItem = new ToolStripMenuItem();
            restoreToolStripMenuItem = new ToolStripMenuItem();
            bitacoraToolStripMenuItem = new ToolStripMenuItem();
            gestionDePermisosToolStripMenuItem1 = new ToolStripMenuItem();
            aBMUsuarioToolStripMenuItem = new ToolStripMenuItem();
            gestionRolpermisoToolStripMenuItem = new ToolStripMenuItem();
            cobrarTasacionToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, gestionDeClientesToolStripMenuItem, gestionDeInmueblesToolStripMenuItem, gestionAdministrativaToolStripMenuItem, gestionDeReportesToolStripMenuItem, gestionDePermisosToolStripMenuItem, gestionDePermisosToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1262, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loginToolStripMenuItem, logoutToolStripMenuItem });
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(59, 24);
            inicioToolStripMenuItem.Text = "Inicio";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(139, 26);
            loginToolStripMenuItem.Text = "Salir";
            loginToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(139, 26);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // gestionDeClientesToolStripMenuItem
            // 
            gestionDeClientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { carteraDeClientesToolStripMenuItem, registroDeInteraccionesToolStripMenuItem, calendarioDeVisitasToolStripMenuItem1 });
            gestionDeClientesToolStripMenuItem.Name = "gestionDeClientesToolStripMenuItem";
            gestionDeClientesToolStripMenuItem.Size = new Size(148, 24);
            gestionDeClientesToolStripMenuItem.Text = "Gestion de clientes";
            // 
            // carteraDeClientesToolStripMenuItem
            // 
            carteraDeClientesToolStripMenuItem.Name = "carteraDeClientesToolStripMenuItem";
            carteraDeClientesToolStripMenuItem.Size = new Size(228, 26);
            carteraDeClientesToolStripMenuItem.Text = "Cartera de clientes";
            carteraDeClientesToolStripMenuItem.Click += carteraDeClientesToolStripMenuItem_Click;
            // 
            // registroDeInteraccionesToolStripMenuItem
            // 
            registroDeInteraccionesToolStripMenuItem.Name = "registroDeInteraccionesToolStripMenuItem";
            registroDeInteraccionesToolStripMenuItem.Size = new Size(228, 26);
            registroDeInteraccionesToolStripMenuItem.Text = "Registrar interaccion";
            registroDeInteraccionesToolStripMenuItem.Click += registroDeInteraccionesToolStripMenuItem_Click;
            // 
            // calendarioDeVisitasToolStripMenuItem1
            // 
            calendarioDeVisitasToolStripMenuItem1.Name = "calendarioDeVisitasToolStripMenuItem1";
            calendarioDeVisitasToolStripMenuItem1.Size = new Size(228, 26);
            calendarioDeVisitasToolStripMenuItem1.Text = "Programar visita";
            calendarioDeVisitasToolStripMenuItem1.Click += calendarioDeVisitasToolStripMenuItem_Click;
            // 
            // gestionDeInmueblesToolStripMenuItem
            // 
            gestionDeInmueblesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { propiedadesToolStripMenuItem, contratosToolStripMenuItem, estadoToolStripMenuItem });
            gestionDeInmueblesToolStripMenuItem.Name = "gestionDeInmueblesToolStripMenuItem";
            gestionDeInmueblesToolStripMenuItem.Size = new Size(166, 24);
            gestionDeInmueblesToolStripMenuItem.Text = "Gestion de inmuebles";
            // 
            // propiedadesToolStripMenuItem
            // 
            propiedadesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { catalogoDePropiedadesToolStripMenuItem, aBMDePropiedadesToolStripMenuItem });
            propiedadesToolStripMenuItem.Name = "propiedadesToolStripMenuItem";
            propiedadesToolStripMenuItem.Size = new Size(281, 26);
            propiedadesToolStripMenuItem.Text = "Propiedades";
            // 
            // catalogoDePropiedadesToolStripMenuItem
            // 
            catalogoDePropiedadesToolStripMenuItem.Name = "catalogoDePropiedadesToolStripMenuItem";
            catalogoDePropiedadesToolStripMenuItem.Size = new Size(228, 26);
            catalogoDePropiedadesToolStripMenuItem.Text = "Consultar catálogo";
            catalogoDePropiedadesToolStripMenuItem.Click += catalogoDePropiedadesToolStripMenuItem_Click;
            // 
            // aBMDePropiedadesToolStripMenuItem
            // 
            aBMDePropiedadesToolStripMenuItem.Name = "aBMDePropiedadesToolStripMenuItem";
            aBMDePropiedadesToolStripMenuItem.Size = new Size(228, 26);
            aBMDePropiedadesToolStripMenuItem.Text = "Alta de propiedades";
            aBMDePropiedadesToolStripMenuItem.Click += aBMDePropiedadesToolStripMenuItem_Click;
            // 
            // contratosToolStripMenuItem
            // 
            contratosToolStripMenuItem.Name = "contratosToolStripMenuItem";
            contratosToolStripMenuItem.Size = new Size(281, 26);
            contratosToolStripMenuItem.Text = "Gestionar contratos";
            contratosToolStripMenuItem.Click += contratosToolStripMenuItem_Click;
            // 
            // estadoToolStripMenuItem
            // 
            estadoToolStripMenuItem.Name = "estadoToolStripMenuItem";
            estadoToolStripMenuItem.Size = new Size(281, 26);
            estadoToolStripMenuItem.Text = "Actualizar estado propiedad";
            estadoToolStripMenuItem.Click += estadoToolStripMenuItem_Click;
            // 
            // gestionAdministrativaToolStripMenuItem
            // 
            gestionAdministrativaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registrarVentaToolStripMenuItem, calendarioDeTasacionesToolStripMenuItem, cobrarTasacionToolStripMenuItem, reimprimirTasacionesToolStripMenuItem });
            gestionAdministrativaToolStripMenuItem.Name = "gestionAdministrativaToolStripMenuItem";
            gestionAdministrativaToolStripMenuItem.Size = new Size(142, 24);
            gestionAdministrativaToolStripMenuItem.Text = "Gestion comercial";
            // 
            // registrarVentaToolStripMenuItem
            // 
            registrarVentaToolStripMenuItem.Name = "registrarVentaToolStripMenuItem";
            registrarVentaToolStripMenuItem.Size = new Size(275, 26);
            registrarVentaToolStripMenuItem.Text = "Registrar venta";
            registrarVentaToolStripMenuItem.Click += registrarVentaToolStripMenuItem_Click;
            // 
            // calendarioDeTasacionesToolStripMenuItem
            // 
            calendarioDeTasacionesToolStripMenuItem.Name = "calendarioDeTasacionesToolStripMenuItem";
            calendarioDeTasacionesToolStripMenuItem.Size = new Size(275, 26);
            calendarioDeTasacionesToolStripMenuItem.Text = "Programar tasacion";
            calendarioDeTasacionesToolStripMenuItem.Click += calendarioDeTasacionesToolStripMenuItem_Click;
            // 
            // reimprimirTasacionesToolStripMenuItem
            // 
            reimprimirTasacionesToolStripMenuItem.Name = "reimprimirTasacionesToolStripMenuItem";
            reimprimirTasacionesToolStripMenuItem.Size = new Size(275, 26);
            reimprimirTasacionesToolStripMenuItem.Text = "Reimprimir factura tasacion";
            reimprimirTasacionesToolStripMenuItem.Click += reimprimirTasacionesToolStripMenuItem_Click;
            // 
            // gestionDeReportesToolStripMenuItem
            // 
            gestionDeReportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem });
            gestionDeReportesToolStripMenuItem.Name = "gestionDeReportesToolStripMenuItem";
            gestionDeReportesToolStripMenuItem.Size = new Size(153, 24);
            gestionDeReportesToolStripMenuItem.Text = "Gestion de reportes";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(165, 26);
            dashboardToolStripMenuItem.Text = "Dashboard";
            dashboardToolStripMenuItem.Click += dashboardToolStripMenuItem_Click;
            // 
            // gestionDePermisosToolStripMenuItem
            // 
            gestionDePermisosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { backupToolStripMenuItem, restoreToolStripMenuItem, bitacoraToolStripMenuItem });
            gestionDePermisosToolStripMenuItem.Name = "gestionDePermisosToolStripMenuItem";
            gestionDePermisosToolStripMenuItem.Size = new Size(118, 24);
            gestionDePermisosToolStripMenuItem.Text = "Gestion de BD";
            // 
            // backupToolStripMenuItem
            // 
            backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            backupToolStripMenuItem.Size = new Size(213, 26);
            backupToolStripMenuItem.Text = "Crear backup";
            backupToolStripMenuItem.Click += backupToolStripMenuItem_Click;
            // 
            // restoreToolStripMenuItem
            // 
            restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            restoreToolStripMenuItem.Size = new Size(213, 26);
            restoreToolStripMenuItem.Text = "Realizar restore";
            restoreToolStripMenuItem.Click += restoreToolStripMenuItem_Click;
            // 
            // bitacoraToolStripMenuItem
            // 
            bitacoraToolStripMenuItem.Name = "bitacoraToolStripMenuItem";
            bitacoraToolStripMenuItem.Size = new Size(213, 26);
            bitacoraToolStripMenuItem.Text = "Consultar bitácora";
            bitacoraToolStripMenuItem.Click += bitacoraToolStripMenuItem_Click;
            // 
            // gestionDePermisosToolStripMenuItem1
            // 
            gestionDePermisosToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { aBMUsuarioToolStripMenuItem, gestionRolpermisoToolStripMenuItem });
            gestionDePermisosToolStripMenuItem1.Name = "gestionDePermisosToolStripMenuItem1";
            gestionDePermisosToolStripMenuItem1.Size = new Size(152, 24);
            gestionDePermisosToolStripMenuItem1.Text = "Gestion de usuarios";
            // 
            // aBMUsuarioToolStripMenuItem
            // 
            aBMUsuarioToolStripMenuItem.Name = "aBMUsuarioToolStripMenuItem";
            aBMUsuarioToolStripMenuItem.Size = new Size(203, 26);
            aBMUsuarioToolStripMenuItem.Text = "ABM usuario";
            aBMUsuarioToolStripMenuItem.Click += aBMUsuarioToolStripMenuItem_Click;
            // 
            // gestionRolpermisoToolStripMenuItem
            // 
            gestionRolpermisoToolStripMenuItem.Name = "gestionRolpermisoToolStripMenuItem";
            gestionRolpermisoToolStripMenuItem.Size = new Size(203, 26);
            gestionRolpermisoToolStripMenuItem.Text = "Roles y permisos";
            gestionRolpermisoToolStripMenuItem.Click += gestionRolpermisoToolStripMenuItem_Click;
            // 
            // cobrarTasacionToolStripMenuItem
            // 
            cobrarTasacionToolStripMenuItem.Name = "cobrarTasacionToolStripMenuItem";
            cobrarTasacionToolStripMenuItem.Size = new Size(275, 26);
            cobrarTasacionToolStripMenuItem.Text = "Cobrar tasacion";
            cobrarTasacionToolStripMenuItem.Click += cobrarTasacionToolStripMenuItem_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.SIGI_50;
            ClientSize = new Size(1262, 673);
            Controls.Add(menuStrip1);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú principal | Usuario: ";
            Load += FormPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem gestionDeClientesToolStripMenuItem;
        private ToolStripMenuItem carteraDeClientesToolStripMenuItem;
        private ToolStripMenuItem gestionDeInmueblesToolStripMenuItem;
        private ToolStripMenuItem propiedadesToolStripMenuItem;
        private ToolStripMenuItem catalogoDePropiedadesToolStripMenuItem;
        private ToolStripMenuItem contratosToolStripMenuItem;
        private ToolStripMenuItem gestionAdministrativaToolStripMenuItem;
        private ToolStripMenuItem registrarVentaToolStripMenuItem;
        private ToolStripMenuItem calendarioDeTasacionesToolStripMenuItem;
        private ToolStripMenuItem gestionDeReportesToolStripMenuItem;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem gestionDePermisosToolStripMenuItem;
        private ToolStripMenuItem bitacoraToolStripMenuItem;
        private ToolStripMenuItem backupToolStripMenuItem;
        private ToolStripMenuItem restoreToolStripMenuItem;
        private ToolStripMenuItem gestionDePermisosToolStripMenuItem1;
        private ToolStripMenuItem aBMUsuarioToolStripMenuItem;
        private ToolStripMenuItem gestionRolpermisoToolStripMenuItem;
        private ToolStripMenuItem aBMDePropiedadesToolStripMenuItem;
        private ToolStripMenuItem estadoToolStripMenuItem;
        private ToolStripMenuItem registroDeInteraccionesToolStripMenuItem;
        private ToolStripMenuItem calendarioDeVisitasToolStripMenuItem1;
        private ToolStripMenuItem reimprimirTasacionesToolStripMenuItem;
        private ToolStripMenuItem cobrarTasacionToolStripMenuItem;
    }
}
