﻿namespace InfoCostePrograma
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trabajadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoProductoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entrarFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verPresupuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label_IdentificadoComo = new System.Windows.Forms.Label();
            this.label_Identificado = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trabajadoresToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.listadosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(529, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trabajadoresToolStripMenuItem
            // 
            this.trabajadoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearToolStripMenuItem,
            this.gestionarToolStripMenuItem});
            this.trabajadoresToolStripMenuItem.Name = "trabajadoresToolStripMenuItem";
            this.trabajadoresToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.trabajadoresToolStripMenuItem.Text = "Trabajadores";
            // 
            // crearToolStripMenuItem
            // 
            this.crearToolStripMenuItem.Name = "crearToolStripMenuItem";
            this.crearToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.crearToolStripMenuItem.Text = "Crear...";
            this.crearToolStripMenuItem.Click += new System.EventHandler(this.crearToolStripMenuItem_Click);
            // 
            // gestionarToolStripMenuItem
            // 
            this.gestionarToolStripMenuItem.Name = "gestionarToolStripMenuItem";
            this.gestionarToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.gestionarToolStripMenuItem.Text = "Gestionar Trabajadores";
            this.gestionarToolStripMenuItem.Click += new System.EventHandler(this.gestionarToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoProductoToolStripMenuItem,
            this.gestionarToolStripMenuItem1});
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // nuevoProductoToolStripMenuItem
            // 
            this.nuevoProductoToolStripMenuItem.Name = "nuevoProductoToolStripMenuItem";
            this.nuevoProductoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.nuevoProductoToolStripMenuItem.Text = "Nuevo";
            // 
            // gestionarToolStripMenuItem1
            // 
            this.gestionarToolStripMenuItem1.Name = "gestionarToolStripMenuItem1";
            this.gestionarToolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.gestionarToolStripMenuItem1.Text = "Gestionar Productos";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.gestionarProveedoresToolStripMenuItem,
            this.entrarFacturaToolStripMenuItem});
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // gestionarProveedoresToolStripMenuItem
            // 
            this.gestionarProveedoresToolStripMenuItem.Name = "gestionarProveedoresToolStripMenuItem";
            this.gestionarProveedoresToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.gestionarProveedoresToolStripMenuItem.Text = "Gestionar Proveedores";
            // 
            // entrarFacturaToolStripMenuItem
            // 
            this.entrarFacturaToolStripMenuItem.Name = "entrarFacturaToolStripMenuItem";
            this.entrarFacturaToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.entrarFacturaToolStripMenuItem.Text = "Entrar Factura";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem1,
            this.gestiónClientesToolStripMenuItem,
            this.verPresupuestosToolStripMenuItem,
            this.verReservasToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // nuevoToolStripMenuItem1
            // 
            this.nuevoToolStripMenuItem1.Name = "nuevoToolStripMenuItem1";
            this.nuevoToolStripMenuItem1.Size = new System.Drawing.Size(169, 22);
            this.nuevoToolStripMenuItem1.Text = "Nuevo";
            this.nuevoToolStripMenuItem1.Click += new System.EventHandler(this.nuevoToolStripMenuItem1_Click);
            // 
            // gestiónClientesToolStripMenuItem
            // 
            this.gestiónClientesToolStripMenuItem.Name = "gestiónClientesToolStripMenuItem";
            this.gestiónClientesToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.gestiónClientesToolStripMenuItem.Text = "Gestionar Clientes";
            this.gestiónClientesToolStripMenuItem.Click += new System.EventHandler(this.gestiónClientesToolStripMenuItem_Click);
            // 
            // verPresupuestosToolStripMenuItem
            // 
            this.verPresupuestosToolStripMenuItem.Name = "verPresupuestosToolStripMenuItem";
            this.verPresupuestosToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.verPresupuestosToolStripMenuItem.Text = "Ver Presupuestos";
            // 
            // verReservasToolStripMenuItem
            // 
            this.verReservasToolStripMenuItem.Name = "verReservasToolStripMenuItem";
            this.verReservasToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.verReservasToolStripMenuItem.Text = "Ver Reservas";
            // 
            // listadosToolStripMenuItem
            // 
            this.listadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventasToolStripMenuItem,
            this.comprasToolStripMenuItem});
            this.listadosToolStripMenuItem.Name = "listadosToolStripMenuItem";
            this.listadosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.listadosToolStripMenuItem.Text = "Listados";
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 47);
            this.button1.TabIndex = 1;
            this.button1.Text = "Nueva Venta";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label_IdentificadoComo
            // 
            this.label_IdentificadoComo.AutoSize = true;
            this.label_IdentificadoComo.Location = new System.Drawing.Point(13, 236);
            this.label_IdentificadoComo.Name = "label_IdentificadoComo";
            this.label_IdentificadoComo.Size = new System.Drawing.Size(49, 13);
            this.label_IdentificadoComo.TabIndex = 2;
            this.label_IdentificadoComo.Text = "Usuario: ";
            // 
            // label_Identificado
            // 
            this.label_Identificado.AutoSize = true;
            this.label_Identificado.Location = new System.Drawing.Point(69, 236);
            this.label_Identificado.Name = "label_Identificado";
            this.label_Identificado.Size = new System.Drawing.Size(84, 13);
            this.label_Identificado.TabIndex = 3;
            this.label_Identificado.Text = "Ragnar Lodbrok";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 261);
            this.Controls.Add(this.label_Identificado);
            this.Controls.Add(this.label_IdentificadoComo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "InfoCoste Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trabajadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoProductoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gestiónClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem entrarFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verPresupuestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verReservasToolStripMenuItem;
        private System.Windows.Forms.Label label_IdentificadoComo;
        private System.Windows.Forms.Label label_Identificado;
    }
}
