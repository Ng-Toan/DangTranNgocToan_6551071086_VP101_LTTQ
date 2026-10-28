
using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using DangTranNgocToan_6551071086_VP101_LTTQ.Models;

namespace DangTranNgocToan_6551071086_VP101_LTTQ;

public partial class From1 : Form
{
    string? maChon = null;

    public From1()
    {
        InitializeComponent();

        btnThem.Click += btnThem_Click;
        btnSua.Click += btnSua_Click;
        btnXoa.Click += btnXoa_Click;
        btnThoat.Click += btnThoat_Click;
        dgvDanhSach.CellClick += dgvDanhSach_CellClick;
        txtLuong.KeyPress += txtLuong_KeyPress;

        txtMaCongViec.MaxLength = 10;
        txtLuong.MaxLength = 8;

        dgvDanhSach.ReadOnly = true;
        dgvDanhSach.MultiSelect = false;
        dgvDanhSach.AllowUserToAddRows = false;
        dgvDanhSach.AllowUserToDeleteRows = false;
        dgvDanhSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvDanhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        TrangThai(true);

        try
        {
            TaiDanhSach();
            XoaO();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
        }

        Shown += (_, _) =>
        {
            dgvDanhSach.ClearSelection();
            dgvDanhSach.CurrentCell = null;
        };
    }

    void TaiDanhSach()
    {
        using var db = new DuLieuContext();

        dgvDanhSach.DataSource = db.CongViec
            .AsNoTracking()
            .OrderBy(x => x.MaCongViec)
            .Select(x => new
            {
                x.MaCongViec, x.TenCongViec, x.LuongThang
            })
            .ToList();

        dgvDanhSach.ClearSelection();
        dgvDanhSach.CurrentCell = null;
    }

    void XoaO()
    {
        txtMaCongViec.Clear();
        txtTenCongViec.Clear();
        txtLuong.Clear();

        txtMaCongViec.ReadOnly = false;
        maChon = null;

        dgvDanhSach.ClearSelection();
        dgvDanhSach.CurrentCell = null;
    }

    void TrangThai(bool choThem)
    {
        btnThem.Enabled = choThem;
        btnSua.Enabled = false;
        btnXoa.Enabled = false;
        btnThoat.Enabled = true;
    }

    private void txtLuong_KeyPress(object? sender, KeyPressEventArgs e)
    {
        if (!char.IsControl(e.KeyChar) &&
            (e.KeyChar < '0' || e.KeyChar > '9'))
        {
            e.Handled = true;
        }
    }

    bool HopLe()
    {
        if (string.IsNullOrWhiteSpace(txtMaCongViec.Text))
        {
            MessageBox.Show("Vui lòng nhập mã công việc!");
            txtMaCongViec.Focus();
            return false;
        }

        if (string.IsNullOrWhiteSpace(txtTenCongViec.Text))
        {
            MessageBox.Show("Vui lòng nhập tên công việc!");
            txtTenCongViec.Focus();
            return false;
        }

        if (!Regex.IsMatch(txtLuong.Text.Trim(), @"^[0-9]{1,8}$"))
        {
            MessageBox.Show("Lương tháng phải là số nguyên!");
            txtLuong.Focus();
            return false;
        }

        return true;
    }

    private void btnThem_Click(object? sender, EventArgs e)
    {
        if (!HopLe()) return;

        try
        {
            using var db = new DuLieuContext();
            string ma = txtMaCongViec.Text.Trim();

            if (db.CongViec.Any(x => x.MaCongViec == ma))
            {
                MessageBox.Show("Mã công việc đã tồn tại!");
                txtMaCongViec.Focus();
                return;
            }

            var cv = new CongViec
            {
                MaCongViec = ma,
                TenCongViec = txtTenCongViec.Text.Trim(),
                LuongThang = txtLuong.Text.Trim()
            };

            db.CongViec.Add(cv);
            db.SaveChanges();

            TaiDanhSach();
            XoaO();
            TrangThai(true);

            MessageBox.Show("Thêm công việc thành công!");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi thêm: " + ex.Message);
        }
    }

    private void dgvDanhSach_CellClick(
        object? sender,
        DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;

        var row = dgvDanhSach.Rows[e.RowIndex];

        maChon = row.Cells["MaCongViec"].Value?.ToString();

        if (string.IsNullOrEmpty(maChon)) return;

        txtMaCongViec.Text = maChon;
        txtTenCongViec.Text = row.Cells["TenCongViec"].Value?.ToString();
        txtLuong.Text = row.Cells["LuongThang"].Value?.ToString();

        txtMaCongViec.ReadOnly = true;

        btnThem.Enabled = true;
        btnSua.Enabled = true;
        btnXoa.Enabled = true;
        btnThoat.Enabled = true;
    }

    private void btnSua_Click(object? sender, EventArgs e)
    {
        if (maChon == null || !HopLe()) return;

        try
        {
            using var db = new DuLieuContext();

            var cv = db.CongViec.Find(maChon);

            if (cv == null)
            {
                MessageBox.Show("Không tìm thấy công việc!");
                return;
            }

            cv.TenCongViec = txtTenCongViec.Text.Trim();
            cv.LuongThang = txtLuong.Text.Trim();

            db.SaveChanges();

            TaiDanhSach();
            XoaO();
            TrangThai(true);

            MessageBox.Show("Sửa công việc thành công!");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi sửa: " + ex.Message);
        }
    }

    private void btnXoa_Click(object? sender, EventArgs e)
    {
        if (maChon == null) return;

        var kq = MessageBox.Show("Bạn có muốn xóa công việc này không?", "Xác nhận",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (kq == DialogResult.Yes)
        {
            try
            {
                using var db = new DuLieuContext();

                var cv = db.CongViec.Find(maChon);

                if (cv == null)
                {
                    MessageBox.Show("Không tìm thấy công việc!");
                    return;
                }

                db.CongViec.Remove(cv);
                db.SaveChanges();

                TaiDanhSach();

                MessageBox.Show("Xóa công việc thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa: " + ex.Message);
                return;
            }
        }

        XoaO();
        TrangThai(true);
    }

    private void btnThoat_Click(object? sender, EventArgs e)
    {
        var kq = MessageBox.Show("Bạn có muốn thoát không?", "Xác nhận",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (kq == DialogResult.Yes)
        {
            Close();
        }
    }
}
